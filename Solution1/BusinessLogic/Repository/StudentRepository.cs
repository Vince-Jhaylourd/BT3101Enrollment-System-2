using System;
using System.Collections.Generic;
using System.Globalization;
using Microsoft.Data.Sqlite;
using System.Data;
using Model;

namespace BusinessLogic.Repository
{
    public class StudentRepository
    {
        private readonly SQLiteDatabase _database;

        public StudentRepository()
        {
            _database = new SQLiteDatabase();
            _database.InitializeDatabase();
        }
        //updated(?)
        private const string SelectColumns =
           "StudentId, LRN, LastName, FirstName, MiddleName, Gender, DateOfBirth, " +
           "ContactNo, GuardianName, GuardianContact, Address";

        private static string Str(SqliteDataReader r, string col)
        {
            int i = r.GetOrdinal(col);
            return r.IsDBNull(i) ? null : r.GetString(i);
        }

        private static Student Map(SqliteDataReader r) => new Student
        {
            StudentId = r.GetInt32(r.GetOrdinal("StudentId")),
            LRN = Str(r, "LRN"),
            LastName = Str(r, "LastName"),
            FirstName = Str(r, "FirstName"),
            MiddleName = Str(r, "MiddleName"),
            Gender = Str(r, "Gender"),
            DateOfBirth = DateTime.Parse(Str(r, "DateOfBirth"), CultureInfo.InvariantCulture),
            ContactNo = Str(r, "ContactNo"),
            GuardianName = Str(r, "GuardianName"),
            GuardianContact = Str(r, "GuardianContact"),
            Address = Str(r, "Address"),
        };

        private static void AddFields(SqliteCommand cmd, Student s)
        {
            cmd.Parameters.AddWithValue("@LRN", s.LRN);
            cmd.Parameters.AddWithValue("@LastName", s.LastName);
            cmd.Parameters.AddWithValue("@FirstName", s.FirstName);
            cmd.Parameters.AddWithValue("@MiddleName", (object)s.MiddleName ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Gender", s.Gender);
            cmd.Parameters.AddWithValue("@DateOfBirth", s.DateOfBirth.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
            cmd.Parameters.AddWithValue("@ContactNo", s.ContactNo);
            cmd.Parameters.AddWithValue("@GuardianName", s.GuardianName);
            cmd.Parameters.AddWithValue("@GuardianContact", s.GuardianContact);
            cmd.Parameters.AddWithValue("@Address", (object)s.Address ?? DBNull.Value);
        }

        private List<Student> Query(string where, string query)
        {
            var list = new List<Student>();
            using (var con = _database.GetConnection())
            {
                con.Open();
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText =
                        "SELECT " + SelectColumns + " FROM Students WHERE IsDeleted = 0 " + where +
                        " ORDER BY LastName, FirstName";
                    if (query != null) cmd.Parameters.AddWithValue("@Query", query);
                    using (var r = cmd.ExecuteReader())
                        while (r.Read()) list.Add(Map(r));
                }
            }
            return list;
        }

        public List<Student> GetAll() => Query("", null);

        public int GetTotalStudents()
        {
            using (var con = _database.GetConnection())
            {
                con.Open();

                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = @"
                SELECT COUNT(*)
                FROM Students
                WHERE IsDeleted = 0";

                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        public List<Student> Search(string query)
        {
            if (string.IsNullOrEmpty(query)) return GetAll();
            return Query(
                @"AND (LRN LIKE '%' || @Query || '%'
                    OR CAST(StudentId AS TEXT) = @Query
                    OR LastName  LIKE '%' || @Query || '%'
                    OR FirstName LIKE '%' || @Query || '%'
                    OR (LastName || ', ' || FirstName) LIKE '%' || @Query || '%'
                    OR (FirstName || ' ' || LastName) LIKE '%' || @Query || '%')",
                query);
        }

        private static bool LrnTaken(SqliteConnection con, string lrn, int exceptStudentId)
        {
            using (var cmd = con.CreateCommand())
            {
                cmd.CommandText = "SELECT 1 FROM Students WHERE LRN = @LRN AND IsDeleted = 0 AND StudentId <> @Id LIMIT 1";
                cmd.Parameters.AddWithValue("@LRN", lrn);
                cmd.Parameters.AddWithValue("@Id", exceptStudentId);
                return cmd.ExecuteScalar() != null;
            }
        }

        public int Add(Student s)
        {
            using (var con = _database.GetConnection())
            {
                con.Open();
                if (LrnTaken(con, s.LRN, 0))
                    throw new InvalidOperationException("A student with this LRN already exists.");

                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText =
                        @"INSERT INTO Students (LRN, LastName, FirstName, MiddleName, Gender, DateOfBirth,
                                                ContactNo, GuardianName, GuardianContact, Address)
                          VALUES (@LRN, @LastName, @FirstName, @MiddleName, @Gender, @DateOfBirth,
                                  @ContactNo, @GuardianName, @GuardianContact, @Address);
                          SELECT last_insert_rowid();";
                    AddFields(cmd, s);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        public void Update(Student s)
        {
            using (var con = _database.GetConnection())
            {
                con.Open();
                if (LrnTaken(con, s.LRN, s.StudentId))
                    throw new InvalidOperationException("Another student with this LRN already exists.");

                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText =
                        @"UPDATE Students
                          SET LRN = @LRN, LastName = @LastName, FirstName = @FirstName, MiddleName = @MiddleName,
                              Gender = @Gender, DateOfBirth = @DateOfBirth, ContactNo = @ContactNo,
                              GuardianName = @GuardianName, GuardianContact = @GuardianContact, Address = @Address
                          WHERE StudentId = @StudentId AND IsDeleted = 0";
                    AddFields(cmd, s);
                    cmd.Parameters.AddWithValue("@StudentId", s.StudentId);
                    if (cmd.ExecuteNonQuery() == 0)
                        throw new InvalidOperationException("Student record not found.");
                }
            }
        }

        public void Delete(int studentId)
        {
            using (var con = _database.GetConnection())
            {
                con.Open();
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = "UPDATE Students SET IsDeleted = 1 WHERE StudentId = @StudentId AND IsDeleted = 0";
                    cmd.Parameters.AddWithValue("@StudentId", studentId);
                    if (cmd.ExecuteNonQuery() == 0)
                        throw new InvalidOperationException("Student record not found.");
                }
            }
        }
        public void SeedSampleStudents()
        {
            string[] firstNames =
            {
        "Alex", "Joshua", "Daniel", "Michael", "Gabriel",
        "Sophia", "Emma", "Olivia", "Mia", "Isabella",
        "Ethan", "Noah", "Liam", "Lucas", "James"
    };

            string[] lastNames =
            {
        "Santos", "Reyes", "Cruz", "Garcia", "Mendoza",
        "Dela Cruz", "Ramos", "Torres", "Flores", "Castillo"
    };

            using (var con = _database.GetConnection())
            {
                con.Open();

                for (int i = 1; i <= 55; i++)
                {
                    using (var cmd = con.CreateCommand())
                    {
                        cmd.CommandText = @"
                    INSERT OR IGNORE INTO Students
                    (LRN, LastName, FirstName, MiddleName, Gender,
                     DateOfBirth, ContactNo, GuardianName,
                     GuardianContact, Address)
                    VALUES
                    (@LRN, @LastName, @FirstName, @MiddleName, @Gender,
                     @DateOfBirth, @ContactNo, @GuardianName,
                     @GuardianContact, @Address);";

                        cmd.Parameters.AddWithValue("@LRN",
                            (900000000000L + i).ToString());

                        cmd.Parameters.AddWithValue("@LastName",
                            lastNames[(i - 1) % lastNames.Length]);

                        cmd.Parameters.AddWithValue("@FirstName",
                            firstNames[(i - 1) % firstNames.Length]);

                        cmd.Parameters.AddWithValue("@MiddleName", "Sample");

                        cmd.Parameters.AddWithValue("@Gender",
                            i % 2 == 0 ? "Female" : "Male");

                        cmd.Parameters.AddWithValue("@DateOfBirth",
                            new DateTime(2008, 1, 1)
                                .AddDays(i * 17)
                                .ToString("yyyy-MM-dd"));

                        cmd.Parameters.AddWithValue("@ContactNo", "00000000000");
                        cmd.Parameters.AddWithValue("@GuardianName", "Sample Guardian");
                        cmd.Parameters.AddWithValue("@GuardianContact", "00000000000");
                        cmd.Parameters.AddWithValue("@Address", "Sample Address");

                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
        public List<Student> GetEnrolledStudents()
        {
            var list = new List<Student>();

            using (var con = _database.GetConnection())
            {
                con.Open();

                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = @"
                SELECT DISTINCT
                    s.StudentId,
                    s.LRN,
                    s.LastName,
                    s.FirstName,
                    s.MiddleName,
                    s.Gender,
                    s.DateOfBirth,
                    s.ContactNo,
                    s.GuardianName,
                    s.GuardianContact,
                    s.Address
                FROM Students s
                INNER JOIN Enrollments e
                    ON s.StudentId = e.StudentId
                WHERE s.IsDeleted = 0
                ORDER BY s.LastName, s.FirstName;";

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                                    list.Add(Map(reader));
                        }
                    }
                }
            }

            return list;
        }
        public DataTable GetStudentInformationReport(
            string studentType,
            string gradeLevel,
            string section,
            string schoolYear)
        {
            var table = new DataTable();

            using (var con = _database.GetConnection())
            {
                con.Open();

                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = @"
                SELECT DISTINCT
                    s.StudentId,
                    s.LRN,
                    s.LastName,
                    s.FirstName,
                    s.MiddleName,
                    s.Gender,
                    s.DateOfBirth,
                    s.ContactNo,
                    s.GuardianName,
                    s.GuardianContact,
                    s.Address,
                    sec.GradeLevel,
                    sec.SectionName AS Section,
                    e.SchoolYear
                FROM Enrollments e
                INNER JOIN Students s
                    ON s.StudentId = e.StudentId
                INNER JOIN Sections sec
                    ON sec.SectionId = e.SectionId
                WHERE s.IsDeleted = 0
                  AND e.Status = 'Enrolled'
                  AND e.SchoolYear = @SchoolYear
                  AND (
                      @StudentType = 'All Enrolled'
                      OR (
                          @StudentType = 'By Grade Level'
                          AND sec.GradeLevel = @GradeLevel
                      )
                      OR (
                          @StudentType = 'By Section'
                          AND sec.SectionName = @Section
                      )
                  )
                ORDER BY
                    sec.GradeLevel,
                    sec.SectionName,
                    s.LastName,
                    s.FirstName;";

                    cmd.Parameters.AddWithValue("@StudentType", studentType);
                    cmd.Parameters.AddWithValue("@GradeLevel", gradeLevel);
                    cmd.Parameters.AddWithValue("@Section", section);
                    cmd.Parameters.AddWithValue("@SchoolYear", schoolYear);

                    using (var reader = cmd.ExecuteReader())
                    {
                        table.Load(reader);
                    }
                }
            }

            return table;
        }
    }
}