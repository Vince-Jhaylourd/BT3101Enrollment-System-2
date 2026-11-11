using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;

namespace BusinessLogic.Repository
{
    public class AssessmentRepository
    {
        private readonly SQLiteDatabase _database;

        public AssessmentRepository()
        {
            _database = new SQLiteDatabase();
            _database.InitializeDatabase();
        }


        // Get tuition fee based on grade level
        public decimal GetTuitionFee(string gradeLevel)
        {
            switch (gradeLevel)
            {
                case "Grade 1":
                case "Grade 2":
                case "Grade 3":
                case "Grade 4":
                case "Grade 5":
                case "Grade 6":
                    return 20000;

                case "Grade 7":
                case "Grade 8":
                case "Grade 9":
                case "Grade 10":
                    return 26000;

                case "Grade 11":
                case "Grade 12":
                    return 32000;

                default:
                    return 0;
            }
        }

        // Get mandatory school fees based on grade level
        public decimal GetMandatorySchoolFees(string gradeLevel)
        {
            switch (gradeLevel)
            {
                case "Grade 1":
                case "Grade 2":
                case "Grade 3":
                case "Grade 4":
                case "Grade 5":
                case "Grade 6":
                    return 3500;

                case "Grade 7":
                case "Grade 8":
                case "Grade 9":
                case "Grade 10":
                    return 4500;

                case "Grade 11":
                case "Grade 12":
                    return 5000;

                default:
                    return 0;
            }
        }

        // Calculate scholarship/discount amount
        public decimal CalculateDiscount(
            decimal tuitionFee,
            decimal discountPercent)
        {
            return tuitionFee * (discountPercent / 100);
        }

        // Calculate final assessment
        public decimal CalculateTotalAssessment(
            decimal tuitionFee,
            decimal mandatorySchoolFees,
            decimal discountAmount)
        {
            return tuitionFee + mandatorySchoolFees - discountAmount;
        }
        public void SaveAssessment(
            int studentId,
            string schoolYear,
            decimal totalFees,
            decimal discount)
        {
            using (var connection = _database.GetConnection())
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Find the student's enrollment for this school year
                        string enrollmentSql = @"
                    SELECT EnrollmentId
                    FROM Enrollments
                    WHERE StudentId = @StudentId
                    AND SchoolYear = @SchoolYear
                    LIMIT 1;";

                        int enrollmentId;

                        using (var command = connection.CreateCommand())
                        {
                            command.Transaction = transaction;
                            command.CommandText = enrollmentSql;

                            command.Parameters.AddWithValue("@StudentId", studentId);
                            command.Parameters.AddWithValue("@SchoolYear", schoolYear);

                            object result = command.ExecuteScalar();

                            if (result == null)
                            {
                                throw new Exception(
                                    "The student has no enrollment for this school year."
                                );
                            }

                            enrollmentId = Convert.ToInt32(result);
                        }

                        // Save the assessment
                        string assessmentSql = @"
                    INSERT INTO Assessments
                    (EnrollmentId, TotalFees, Discount)
                    VALUES
                    (@EnrollmentId, @TotalFees, @Discount);";

                        using (var command = connection.CreateCommand())
                        {
                            command.Transaction = transaction;
                            command.CommandText = assessmentSql;

                            command.Parameters.AddWithValue(
                                "@EnrollmentId", enrollmentId);

                            command.Parameters.AddWithValue(
                                "@TotalFees", totalFees);

                            command.Parameters.AddWithValue(
                                "@Discount", discount);

                            command.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
        public void CreateEnrollmentAndAssessment(
             int studentId,
             int sectionId,
             string schoolYear,
             decimal totalFees,
             decimal discount)
        {
            using (var connection = _database.GetConnection())
            {
                connection.Open();


                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Create enrollment
                        int enrollmentId;

                        string enrollmentSql = @"
                    INSERT INTO Enrollments
                    (StudentId, SectionId, SchoolYear)
                    VALUES
                    (@StudentId, @SectionId, @SchoolYear);

                    SELECT last_insert_rowid();";

                        using (var command = connection.CreateCommand())
                        {
                            command.Transaction = transaction;
                            command.CommandText = enrollmentSql;

                            command.Parameters.AddWithValue("@StudentId", studentId);
                            command.Parameters.AddWithValue("@SectionId", sectionId);
                            command.Parameters.AddWithValue("@SchoolYear", schoolYear);

                            enrollmentId = Convert.ToInt32(command.ExecuteScalar());
                        }

                        // Create assessment
                        string assessmentSql = @"
                    INSERT INTO Assessments
                    (EnrollmentId, TotalFees, Discount)
                    VALUES
                    (@EnrollmentId, @TotalFees, @Discount);";

                        using (var command = connection.CreateCommand())
                        {
                            command.Transaction = transaction;
                            command.CommandText = assessmentSql;

                            command.Parameters.AddWithValue("@EnrollmentId", enrollmentId);
                            command.Parameters.AddWithValue("@TotalFees", totalFees);
                            command.Parameters.AddWithValue("@Discount", discount);

                            command.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
        public int GetAvailableSectionId(
            string gradeLevel,
            string schoolYear)
        {
            using (var connection = _database.GetConnection())
            {
                connection.Open();

                string sql = @"
            SELECT SectionId
            FROM Sections
            WHERE GradeLevel = @GradeLevel
              AND SchoolYear = @SchoolYear
              AND IsActive = 1
            ORDER BY SectionId
            LIMIT 1;";

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = sql;

                    command.Parameters.AddWithValue(
                        "@GradeLevel", gradeLevel);

                    command.Parameters.AddWithValue(
                        "@SchoolYear", schoolYear);

                    object result = command.ExecuteScalar();

                    if (result == null)
                    {
                        return 0;
                    }

                    return Convert.ToInt32(result);
                }
            }
        }
        public bool HasEnrollment(int studentId, string schoolYear)
        {
            using (var connection = _database.GetConnection())
            {
                connection.Open();

                string sql = @"
            SELECT COUNT(*)
            FROM Enrollments
            WHERE StudentId = @StudentId
              AND SchoolYear = @SchoolYear;";

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = sql;

                    command.Parameters.AddWithValue("@StudentId", studentId);
                    command.Parameters.AddWithValue("@SchoolYear", schoolYear);

                    long count = (long)command.ExecuteScalar();

                    return count > 0;
                }
            }
        }
        public List<dynamic> GetAssessedStudents()
        {
            var students = new List<dynamic>();

            using (var connection = _database.GetConnection())
            {
                connection.Open();

                string sql = @"
            SELECT
                s.StudentId,
                s.LRN,
                s.LastName,
                s.FirstName,
                s.MiddleName,
                sec.GradeLevel,
                sec.SectionName,
                e.SchoolYear,
                a.TotalFees,
                a.Discount
            FROM Assessments a
            INNER JOIN Enrollments e
                ON a.EnrollmentId = e.EnrollmentId
            INNER JOIN Students s
                ON e.StudentId = s.StudentId
            INNER JOIN Sections sec
                ON e.SectionId = sec.SectionId
            ORDER BY s.LastName, s.FirstName;";

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = sql;

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            students.Add(new
                            {
                                StudentId = reader.GetInt32(0),
                                LRN = reader.GetString(1),
                                LastName = reader.GetString(2),
                                FirstName = reader.GetString(3),
                                MiddleName = reader.IsDBNull(4) ? "" : reader.GetString(4),
                                GradeLevel = reader.GetString(5),
                                Section = reader.GetString(6),
                                SchoolYear = reader.GetString(7),
                                TotalFees = reader.GetDouble(8),
                                Discount = reader.GetDouble(9)
                            });
                        }
                    }
                }
            }

            return students;
        }
    }
}