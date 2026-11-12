using System;
using Microsoft.Data.Sqlite;
using System.Collections.Generic;
using BusinessLogic;

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

        public void RecordPayment(
            int assessmentId,
            decimal amount,
            string paymentMethod,
            string referenceNumber)
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
    }
}