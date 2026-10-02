using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Microsoft.Data.Sqlite;
using System.Diagnostics;



namespace BusinessLogic.Repository
{
    public class StudentRepository
    {
        private readonly SQLiteDatabase _database;

        public StudentRepository()
        {
            _database = new SQLiteDatabase();
        }
        //add students
        public void AddStudent(Student student)
        {
            using (var connection = _database.GetConnection())
            {
                connection.Open();
                string sql = @"
                    INSERT INTO Students (FullName, DateOfBirth, LRN, ContactInfo, GuardianContactInfo, isActive)
                    VALUES (@FullName, @DateOfBirth, @LRN, @ContactInfo, @GuardianContactInfo, @isActive);
                ";
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = sql;

                    command.Parameters.AddWithValue("@FullName", student.FullName);
                    command.Parameters.AddWithValue("@DateOfBirth", student.DateOfBirth.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@LRN", student.LRN);
                    command.Parameters.AddWithValue("@ContactInfo", student.ContactInfo);
                    command.Parameters.AddWithValue("@GuardianContactInfo", student.GuardianContactInfo);
                    command.Parameters.AddWithValue("@isActive", student.isActive ? 1 : 0);

                    command.ExecuteNonQuery();

                }
            }

        }

        public List<Student> GetStudents(string searchText)
        {
            var students = new List<Student>();
            using (var connection = _database.GetConnection())
            {
                connection.Open();
                string sql = @"
                    SELECT StudentId, FullName, DateOfBirth, LRN, ContactInfo, GuardianContactInfo, isActive
                    FROM Students
                    WHERE isActive = 1 AND (FullName LIKE @SearchText OR LRN LIKE @SearchText) ORDER BY StudentId;";
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            students.Add(new Student
                            {
                                StudentId = Convert.ToInt32(reader["StudentId"]),
                                FullName = Convert.ToString(reader["FullName"].ToString()),
                                DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"].ToString()),
                                LRN = Convert.ToString(reader["LRN"].ToString()),
                                ContactInfo = Convert.ToString(reader["ContactInfo"].ToString()),
                                GuardianContactInfo = Convert.ToString(reader["GuardianContactInfo"].ToString()),
                                isActive = Convert.ToInt32(reader["isActive"]) == 1

                            } );
                        }
                    }
                }
            }
            return students;
        }
        //update student
        public void UpdateStudent (Student student)
        { 
            using (var connection = _database.GetConnection())
            {
                connection.Open();

                string sql = @"
                    UPDATE Students SET FullName = @FullName, DateOfBirth = @DateOfBirth, LRN = @LRN, ContactInfo = @ContactInfo, GuardianContactInfo = @GuardianContactInfo WHERE StudentId = @StudentId";

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = sql;

                    command.Parameters.AddWithValue("@StudentId", student.StudentId);
                    command.Parameters.AddWithValue("@FullName", student.FullName);
                    command.Parameters.AddWithValue("@DateOfBirth", student.DateOfBirth.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@LRN", student.LRN);
                    command.Parameters.AddWithValue("@ContactInfo", student.ContactInfo);
                    command.Parameters.AddWithValue("@GuardianContactInfo", student.GuardianContactInfo);

                    command.ExecuteNonQuery();
                    
                }
            }
        }
        public void DeleteStudent(int studentId)
        {
            using (var connection = _database.GetConnection())
            {
                connection.Open();

                string sql = @"
                UPDATE Students SET IsActive = 0 WHERE StudentId = @StudentId";

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.Parameters.AddWithValue("@StudentId", studentId);

                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
