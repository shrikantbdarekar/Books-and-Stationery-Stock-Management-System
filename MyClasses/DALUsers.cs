using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WinBookStationaryStock19.MyClasses
{
    public class DALUsers : DatabaseConnection
    {
        public DALUsers(string connectionString) : base(connectionString) { }

        public void AddUser(User user)
        {
            using (var connection = GetConnection())
            {
                var command = new SqlCommand("INSERT INTO Users (Username, UserPassword, UserRole) VALUES (@Username, @UserPassword, @UserRole)", connection);
                command.Parameters.AddWithValue("@Username", user.Username);
                command.Parameters.AddWithValue("@UserPassword", user.UserPassword);
                command.Parameters.AddWithValue("@UserRole", user.UserRole);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public User GetUserById(int userId)
        {
            using (var connection = GetConnection())
            {
                var command = new SqlCommand("SELECT * FROM Users WHERE UserID = @UserID", connection);
                command.Parameters.AddWithValue("@UserID", userId);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new User
                        {
                            UserID = (int)reader["UserID"],
                            Username = (string)reader["Username"],
                            UserPassword = (string)reader["UserPassword"],
                            UserRole = (string)reader["UserRole"]
                        };
                    }
                }
            }
            return null;
        }

        public void UpdateUser(User user)
        {
            using (var connection = GetConnection())
            {
                var command = new SqlCommand("UPDATE Users SET Username = @Username, UserPassword = @UserPassword, UserRole = @UserRole WHERE UserID = @UserID", connection);
                command.Parameters.AddWithValue("@UserID", user.UserID);
                command.Parameters.AddWithValue("@Username", user.Username);
                command.Parameters.AddWithValue("@UserPassword", user.UserPassword);
                command.Parameters.AddWithValue("@UserRole", user.UserRole);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeleteUser(int userId)
        {
            using (var connection = GetConnection())
            {
                var command = new SqlCommand("DELETE FROM Users WHERE UserID = @UserID", connection);
                command.Parameters.AddWithValue("@UserID", userId);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<User> GetUserList()
        {
            var users = new List<User>();
            using (var connection = GetConnection())
            {
                var command = new SqlCommand("SELECT * FROM Users Order By UserName", connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var userObj = new User
                        {
                            UserID = (int)reader["UserID"],
                            Username = (string)reader["UserName"],
                            UserRole=(string)reader["UserRole"]

                        };
                        users.Add(userObj);
                    }
                }
            }
            return users;
        }
    }

}
