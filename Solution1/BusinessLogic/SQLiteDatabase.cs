using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using System.IO;

namespace BusinessLogic
{
    public class SQLiteDatabase
    {
        private readonly string _connectionString;
        public SQLiteDatabase()
        {
            string databasePath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory, "EnrollmentDatabase.db"
                );
            _connectionString = $"Data Source={databasePath}";
        }
        public SqliteConnection GetConnection()
        {
            return new SqliteConnection(_connectionString);
        }

        public void InitializeDatabase()
        {
            //User
            using (var connection = GetConnection())
            {
                connection.Open();


                string createTableSql = @"
                CREATE TABLE IF NOT EXISTS Users 
                (
                    UserId INTEGER PRIMARY KEY AUTOINCREMENT,
                    Username TEXT NOT NULL,
                    Password TEXT NOT NULL,
                    Role TEXT NOT NULL
                );
             ";

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = createTableSql;
                    command.ExecuteNonQuery();
                }

                string insertUserSql = @"
                INSERT OR IGNORE INTO Users (Username, Password, Role) VALUES
                ('admin', '12345', 'Admin'),
                ('registrar', '12345', 'Registrar'),
                ('cashier', '12345', 'Cashier')
                ;
             ";

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = insertUserSql;
                    command.ExecuteNonQuery();
                }

                string createStudentTableSql = @"
                CREATE TABLE IF NOT EXISTS Students 
                (
                    StudentId       INTEGER PRIMARY KEY AUTOINCREMENT,
                    LRN             TEXT NOT NULL CHECK (length(LRN) = 12 AND LRN NOT GLOB '*[^0-9]*'),
                    LastName        TEXT NOT NULL,
                    FirstName       TEXT NOT NULL,
                    MiddleName      TEXT NULL,
                    Gender          TEXT NOT NULL CHECK (Gender IN ('Male','Female')),
                    DateOfBirth     TEXT NOT NULL,
                    ContactNo       TEXT NOT NULL,
                    GuardianName    TEXT NOT NULL,
                    GuardianContact TEXT NOT NULL,
                    Address         TEXT NULL,
                    IsDeleted       INTEGER NOT NULL DEFAULT 0,
                    CreatedAt       TEXT NOT NULL DEFAULT (datetime('now'))
                );
                CREATE UNIQUE INDEX IF NOT EXISTS UX_Students_LRN_Active
                    ON Students (LRN) WHERE IsDeleted = 0;
             ";

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = createStudentTableSql;
                    command.ExecuteNonQuery();

                }
            }
        }
    }
}
    
