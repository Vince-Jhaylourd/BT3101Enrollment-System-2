using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Model;

namespace BusinessLogic.Repository
{
    public class UserRepository
    {
        private readonly string _connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=EnrollmentSystem;Trusted_Connection=True;TrustServerCertificate=True;";
        public User? Login(string username, string password)
        {
            using SqlConnection connection = new SqlConnection(_connectionString);

            using SqlCommand command = new SqlCommand("dbo.spLogin", connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Password", password);

            connection.Open();

            using SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                return new User
                {
                    UserId = Convert.ToInt32(reader["UserId"]),
                    Username = reader["Username"].ToString() ?? string.Empty
                };

                
            }
            return null;
        }
    }
}
