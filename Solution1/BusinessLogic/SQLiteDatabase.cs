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
            }
        }
    }
}
    
