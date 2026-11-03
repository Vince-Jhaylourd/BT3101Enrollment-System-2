
using System;
using System.IO;
using Microsoft.Data.Sqlite;

namespace BusinessLogic
{
    public class SQLiteDatabase
    {
        private readonly string _connectionString;

        public SQLiteDatabase()
        {
            string databasePath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "EnrollmentDatabase.db"
            );

            _connectionString =
                $"Data Source={databasePath};Foreign Keys=True";
        }

        public SqliteConnection GetConnection()
        {
            return new SqliteConnection(_connectionString);
        }

        public void InitializeDatabase()
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                string createTablesSql = @"

                PRAGMA foreign_keys = ON;

                -- USERS TABLE
                CREATE TABLE IF NOT EXISTS Users
                (
                    UserId INTEGER PRIMARY KEY AUTOINCREMENT,
                    Username TEXT NOT NULL,
                    Password TEXT NOT NULL,
                    Role TEXT NOT NULL
                );

                INSERT OR IGNORE INTO Users
                    (Username, Password, Role)
                VALUES
                    ('admin', '12345', 'Admin'),
                    ('registrar', '12345', 'Registrar'),
                    ('cashier', '12345', 'Cashier');


                -- STUDENTS TABLE
                CREATE TABLE IF NOT EXISTS Students
                (
                    StudentId INTEGER PRIMARY KEY AUTOINCREMENT,
                    LRN TEXT NOT NULL
                        CHECK (
                            length(LRN) = 12
                            AND LRN NOT GLOB '*[^0-9]*'
                        ),
                    LastName TEXT NOT NULL,
                    FirstName TEXT NOT NULL,
                    MiddleName TEXT NULL,
                    Gender TEXT NOT NULL
                        CHECK (Gender IN ('Male', 'Female')),
                    DateOfBirth TEXT NOT NULL,
                    ContactNo TEXT NOT NULL,
                    GuardianName TEXT NOT NULL,
                    GuardianContact TEXT NOT NULL,
                    Address TEXT NULL,
                    IsDeleted INTEGER NOT NULL DEFAULT 0,
                    CreatedAt TEXT NOT NULL DEFAULT (datetime('now'))
                );

                CREATE UNIQUE INDEX IF NOT EXISTS UX_Students_LRN_Active
                ON Students (LRN)
                WHERE IsDeleted = 0;


                -- SECTIONS TABLE
                CREATE TABLE IF NOT EXISTS Sections
                (
                    SectionId INTEGER PRIMARY KEY AUTOINCREMENT,
                    SectionName TEXT NOT NULL,
                    GradeLevel TEXT NOT NULL,
                    SchoolYear TEXT NOT NULL,
                    IsActive INTEGER NOT NULL DEFAULT 1,

                    UNIQUE (SectionName, GradeLevel, SchoolYear)
                );


                -- ENROLLMENTS TABLE
                CREATE TABLE IF NOT EXISTS Enrollments
                (
                    EnrollmentId INTEGER PRIMARY KEY AUTOINCREMENT,
                    StudentId INTEGER NOT NULL,
                    SectionId INTEGER NOT NULL,
                    SchoolYear TEXT NOT NULL,
                    EnrollmentDate TEXT NOT NULL DEFAULT (date('now')),
                    Status TEXT NOT NULL DEFAULT 'Enrolled',

                    FOREIGN KEY (StudentId)
                        REFERENCES Students(StudentId),

                    FOREIGN KEY (SectionId)
                        REFERENCES Sections(SectionId),

                    UNIQUE (StudentId, SchoolYear)
                );


                -- ASSESSMENTS TABLE
                CREATE TABLE IF NOT EXISTS Assessments
                (
                    AssessmentId INTEGER PRIMARY KEY AUTOINCREMENT,
                    EnrollmentId INTEGER NOT NULL UNIQUE,
                    TotalFees REAL NOT NULL DEFAULT 0,
                    Discount REAL NOT NULL DEFAULT 0,
                    AssessmentDate TEXT NOT NULL DEFAULT (date('now')),

                    FOREIGN KEY (EnrollmentId)
                        REFERENCES Enrollments(EnrollmentId),

                    CHECK (TotalFees >= 0),
                    CHECK (Discount >= 0 AND Discount <= TotalFees)
                );


                -- PAYMENTS TABLE
                CREATE TABLE IF NOT EXISTS Payments
                (
                    PaymentId INTEGER PRIMARY KEY AUTOINCREMENT,
                    AssessmentId INTEGER NOT NULL,
                    Amount REAL NOT NULL,
                    PaymentDate TEXT NOT NULL DEFAULT (datetime('now')),
                    PaymentMethod TEXT NOT NULL,
                    ReferenceNumber TEXT NULL,

                    FOREIGN KEY (AssessmentId)
                        REFERENCES Assessments(AssessmentId),

                    CHECK (Amount > 0)
                );


                -- INDEXES
                CREATE INDEX IF NOT EXISTS IX_Enrollments_Student
                ON Enrollments(StudentId);

                CREATE INDEX IF NOT EXISTS IX_Payments_Date
                ON Payments(PaymentDate);

                ";

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = createTablesSql;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
