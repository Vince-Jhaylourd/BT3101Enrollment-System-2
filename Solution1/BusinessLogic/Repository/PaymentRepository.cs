using System;
using Microsoft.Data.Sqlite;
using System.Collections.Generic;
using BusinessLogic;
using Model;

namespace BusinessLogic.Repository
{
    public class PaymentRepository
    {
        private readonly SQLiteDatabase _database;


        public PaymentRepository()
        {
            _database = new SQLiteDatabase();
            _database.InitializeDatabase();
        }

        public int GetAssessmentId(int studentId)
        {
            using (var connection = _database.GetConnection())
            {
                connection.Open();

                string sql = @"
                    SELECT a.AssessmentId
                    FROM Assessments a
                    INNER JOIN Enrollments e
                        ON a.EnrollmentId = e.EnrollmentId
                    WHERE e.StudentId = @StudentId
                    ORDER BY a.AssessmentId DESC
                    LIMIT 1;";

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.Parameters.AddWithValue(
                        "@StudentId",
                        studentId
                    );

                    object result = command.ExecuteScalar();

                    if (result == null)
                        return 0;

                    return Convert.ToInt32(result);
                }
            }
        }

        public int RecordPayment(int assessmentId, decimal amount,string paymentMethod,string referenceNumber)
        {
            using (var connection = _database.GetConnection())
            {
                connection.Open();

                string sql = @"
                    INSERT INTO Payments
                    (
                        AssessmentId,
                        Amount,
                        PaymentMethod,
                        ReferenceNumber
                    )
                    VALUES
                    (
                        @AssessmentId,
                        @Amount,
                        @PaymentMethod,
                        @ReferenceNumber
                    );";

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = sql;

                    command.Parameters.AddWithValue(
                        "@AssessmentId",
                        assessmentId
                    );

                    command.Parameters.AddWithValue(
                        "@Amount",
                        amount
                    );

                    command.Parameters.AddWithValue(
                        "@PaymentMethod",
                        paymentMethod
                    );

                    command.Parameters.AddWithValue(
                        "@ReferenceNumber",
                        string.IsNullOrWhiteSpace(referenceNumber)
                            ? (object)DBNull.Value
                            : referenceNumber
                    );

                    command.ExecuteNonQuery();


                    return Convert.ToInt32(
                        new SqliteCommand("SELECT last_insert_rowid();", connection)
                            .ExecuteScalar());
                }
            }
        }


        public PaymentReceipt GetPaymentReceipt(int paymentId)
        {
            using (var connection = _database.GetConnection())
            {
                connection.Open();

                string sql = @"
            SELECT
                p.PaymentId,
                p.PaymentDate,
                p.Amount,
                p.PaymentMethod,
                p.ReferenceNumber,
                s.StudentId,
                s.LRN,
                s.LastName || ', ' || s.FirstName AS StudentName,
                a.TotalFees,

                (
                    COALESCE(a.TotalFees, 0)
                    - COALESCE((
                        SELECT SUM(previous.Amount)
                        FROM Payments previous
                        WHERE previous.AssessmentId = p.AssessmentId
                          AND previous.PaymentId < p.PaymentId
                    ), 0)
                ) AS PreviousBalance,

                (
                    COALESCE(a.TotalFees, 0)
                    - COALESCE((
                        SELECT SUM(allPayments.Amount)
                        FROM Payments allPayments
                        WHERE allPayments.AssessmentId = p.AssessmentId
                          AND allPayments.PaymentId <= p.PaymentId
                    ), 0)
                ) AS RemainingBalance

            FROM Payments p

            INNER JOIN Assessments a
                ON p.AssessmentId = a.AssessmentId

            INNER JOIN Enrollments e
                ON a.EnrollmentId = e.EnrollmentId

            INNER JOIN Students s
                ON e.StudentId = s.StudentId

            WHERE p.PaymentId = @PaymentId;
        ";

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.Parameters.AddWithValue("@PaymentId", paymentId);

                    using (var reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                            return null;

                        return new PaymentReceipt
                        {
                            PaymentId = Convert.ToInt32(reader["PaymentId"]),
                            PaymentDate = Convert.ToString(reader["PaymentDate"]),

                            Amount = Convert.ToDecimal(reader["Amount"]),

                            PaymentMethod =
                                Convert.ToString(reader["PaymentMethod"]),

                            ReferenceNumber = reader.IsDBNull(4)
                                ? ""
                                : reader.GetString(4),

                            StudentId = Convert.ToInt32(reader["StudentId"]),
                            LRN = Convert.ToString(reader["LRN"]),
                            StudentName = Convert.ToString(reader["StudentName"]),

                            TotalAssessment =
                                Convert.ToDecimal(reader["TotalFees"]),

                            PreviousBalance =
                                Convert.ToDecimal(reader["PreviousBalance"]),

                            RemainingBalance =
                                Convert.ToDecimal(reader["RemainingBalance"])
                        };
                    }
                }
            }
        }


        public List<dynamic> GetPaymentHistory(string searchText = "")
        {
            var payments = new List<dynamic>();

            using (var connection = _database.GetConnection())
            {
                connection.Open();

                string sql = @"
            SELECT
                p.PaymentId,
                s.StudentId,
                s.LRN,
                s.LastName || ', ' || s.FirstName AS StudentName,
                p.Amount,
                p.PaymentMethod,
                p.ReferenceNumber,
                p.PaymentDate
            FROM Payments p

            INNER JOIN Assessments a
                ON p.AssessmentId = a.AssessmentId

            INNER JOIN Enrollments e
                ON a.EnrollmentId = e.EnrollmentId

            INNER JOIN Students s
                ON e.StudentId = s.StudentId

            WHERE
                @SearchText = ''
                OR CAST(s.StudentId AS TEXT) = @SearchText
                OR s.LRN LIKE '%' || @SearchText || '%'
                OR s.LastName LIKE '%' || @SearchText || '%'
                OR s.FirstName LIKE '%' || @SearchText || '%'

            ORDER BY p.PaymentDate DESC;";

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = sql;

                    command.Parameters.AddWithValue(
                        "@SearchText",
                        searchText ?? ""
                    );

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            payments.Add(new
                            {
                                PaymentId = reader.GetInt32(0),
                                StudentId = reader.GetInt32(1),
                                LRN = reader.GetString(2),
                                StudentName = reader.GetString(3),
                                Amount = reader.GetDouble(4),
                                PaymentMethod = reader.GetString(5),
                                ReferenceNumber = reader.IsDBNull(6)
                                    ? ""
                                    : reader.GetString(6),
                                PaymentDate = reader.GetString(7)
                            });
                        }
                    }
                }
            }

            return payments;
        }
        public decimal GetCollectionsToday()
        {
            using (var connection = _database.GetConnection())
            {
                connection.Open();

                string sql = @"
            SELECT COALESCE(SUM(Amount), 0)
            FROM Payments
            WHERE date(PaymentDate, 'localtime') =
                  date('now', 'localtime');
        ";

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = sql;

                    return Convert.ToDecimal(command.ExecuteScalar());
                }
            }
        }
    }
}