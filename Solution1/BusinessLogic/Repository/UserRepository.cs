using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using Model;

namespace BusinessLogic.Repository
{
    public class UserRepository
    {
        private readonly SQLiteDatabase _database;

        public UserRepository()
        {
            _database = new SQLiteDatabase();
            _database.InitializeDatabase();
        }


        public User Login(string username, string password)
        {
            using (var connection = _database.GetConnection())
            {
                connection.Open();

                string sql = @"
                    SELECT UserId, Username, Role
                    FROM Users
                    WHERE Username = @Username
                    AND Password = @Password";

                using var command = connection.CreateCommand();
                command.CommandText = sql;
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new User
                        {
                            UserId = Convert.ToInt32(reader["UserId"]),
                            Username = reader["Username"].ToString() ?? "",
                            Role = reader["Role"].ToString() ?? "" 
                        };

                    }
                }
                return null;
            }
        }
    }
}
