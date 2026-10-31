using System;
using System.Collections.Generic;
using System.Globalization;
using Microsoft.Data.Sqlite;
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

        /// <summary>Soft delete: the row is kept (for payment history), just hidden from lists.</summary>
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
    }
}