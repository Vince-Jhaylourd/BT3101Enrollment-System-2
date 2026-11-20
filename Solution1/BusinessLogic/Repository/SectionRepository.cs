using System;
using BusinessLogic;
using Microsoft.Data.Sqlite;
using Model;
using System.Collections.Generic;

namespace BusinessLogic.Repository
{
    public class SectionRepository
    {
        private readonly SQLiteDatabase _database;

        public SectionRepository()
        {
            _database = new SQLiteDatabase();
            _database.InitializeDatabase();

        }


        public int GetTotalSections()
        {
            using (var connection = _database.GetConnection())
            {
                connection.Open();

                string query = @"
                    SELECT COUNT(*)
                    FROM Sections
                    WHERE IsActive = 1;
                ";

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = query;

                    return Convert.ToInt32(
                        command.ExecuteScalar()
                    );
                }
            }
        }

        public List<Section> GetAllSections()
        {
            var sections = new List<Section>();

            using (var connection = _database.GetConnection())
            {
                connection.Open();

                string query = @"
                    SELECT *
                    FROM Sections
                    WHERE IsActive = 1
                    ORDER BY GradeLevel, SectionName;
                    ";

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = query;

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            sections.Add(new Section
                            {
                                SectionId = Convert.ToInt32(reader["SectionId"]),
                                SectionName = reader["SectionName"].ToString(),
                                GradeLevel = reader["GradeLevel"].ToString(),
                                SchoolYear = reader["SchoolYear"].ToString(),
                                Capacity = Convert.ToInt32(reader["Capacity"]),
                                IsActive = Convert.ToInt32(reader["IsActive"])
                            });
                        }
                    }
                }

                return sections;
            }
        }

        public bool AddSection(Section section)
        {
            using (var connection = _database.GetConnection())
            {
                connection.Open();

                string query = @"
            INSERT INTO Sections
            (SectionName, GradeLevel, SchoolYear, Capacity, IsActive)
            VALUES
            (@SectionName, @GradeLevel, @SchoolYear, @Capacity, 1);
        ";

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = query;

                    command.Parameters.AddWithValue("@SectionName", section.SectionName);
                    command.Parameters.AddWithValue("@GradeLevel", section.GradeLevel);
                    command.Parameters.AddWithValue("@SchoolYear", section.SchoolYear);
                    command.Parameters.AddWithValue("@Capacity", section.Capacity);

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateSection(Section section)
        {
            using (var connection = _database.GetConnection())
            {
                connection.Open();

                string query = @"
            UPDATE Sections
            SET SectionName = @SectionName,
                GradeLevel = @GradeLevel,
                SchoolYear = @SchoolYear,
                Capacity = @Capacity
            WHERE SectionId = @SectionId;
        ";

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = query;

                    command.Parameters.AddWithValue("@SectionId", section.SectionId);
                    command.Parameters.AddWithValue("@SectionName", section.SectionName);
                    command.Parameters.AddWithValue("@GradeLevel", section.GradeLevel);
                    command.Parameters.AddWithValue("@SchoolYear", section.SchoolYear);
                    command.Parameters.AddWithValue("@Capacity", section.Capacity);

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool DeactivateSection(int sectionId)
        {
            using (var connection = _database.GetConnection())
            {
                connection.Open();

                string query = @"
            UPDATE Sections
            SET IsActive = 0
            WHERE SectionId = @SectionId;
        ";

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = query;
                    command.Parameters.AddWithValue("@SectionId", sectionId);

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public int GetStudentCount(int sectionId)
        {
            using (var connection = _database.GetConnection())
            {
                connection.Open();

                string query = @"
            SELECT COUNT(*)
            FROM Enrollments
            WHERE SectionId = @SectionId
              AND Status = 'Enrolled';
        ";

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = query;
                    command.Parameters.AddWithValue("@SectionId", sectionId);

                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }

        public List<Section> GetAvailableSections(string gradeLevel, string schoolYear)
        {
            var sections = new List<Section>();

            using (var connection = _database.GetConnection())
            {
                connection.Open();

                string query = @"
            SELECT SectionId, SectionName, GradeLevel,
                   SchoolYear, Capacity, IsActive
            FROM Sections
            WHERE GradeLevel = @GradeLevel
              AND SchoolYear = @SchoolYear
              AND IsActive = 1
              AND (
                  SELECT COUNT(*)
                  FROM Enrollments
                  WHERE Enrollments.SectionId = Sections.SectionId
                    AND Enrollments.Status = 'Enrolled'
              ) < Capacity
            ORDER BY SectionName;
        ";

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = query;
                    command.Parameters.AddWithValue("@GradeLevel", gradeLevel);
                    command.Parameters.AddWithValue("@SchoolYear", schoolYear);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            sections.Add(new Section
                            {
                                SectionId = Convert.ToInt32(reader["SectionId"]),
                                SectionName = reader["SectionName"].ToString(),
                                GradeLevel = reader["GradeLevel"].ToString(),
                                SchoolYear = reader["SchoolYear"].ToString(),
                                Capacity = Convert.ToInt32(reader["Capacity"]),
                                IsActive = Convert.ToInt32(reader["IsActive"])
                            });
                        }
                    }
                }
            }

            return sections;
        }
    }
}
