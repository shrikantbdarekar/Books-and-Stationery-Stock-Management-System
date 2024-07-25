using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WinBookStationaryStock19.MyClasses
{
    public class DALCategories : DatabaseConnection
    {
        public DALCategories(string connectionString) : base(connectionString) { }

        public void AddCategory(Category category)
        {
            using (var connection = GetConnection())
            {
                var command = new SqlCommand("INSERT INTO Categories (CategoryName) VALUES (@CategoryName)", connection);
                command.Parameters.AddWithValue("@CategoryName", category.CategoryName);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public Category GetCategoryById(int categoryId)
        {
            using (var connection = GetConnection())
            {
                var command = new SqlCommand("SELECT * FROM Categories WHERE CategoryID = @CategoryID", connection);
                command.Parameters.AddWithValue("@CategoryID", categoryId);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Category
                        {
                            CategoryID = (int)reader["CategoryID"],
                            CategoryName = (string)reader["CategoryName"]
                        };
                    }
                }
            }
            return null;
        }

        public void UpdateCategory(Category category)
        {
            using (var connection = GetConnection())
            {
                var command = new SqlCommand("UPDATE Categories SET CategoryName = @CategoryName WHERE CategoryID = @CategoryID", connection);
                command.Parameters.AddWithValue("@CategoryID", category.CategoryID);
                command.Parameters.AddWithValue("@CategoryName", category.CategoryName);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeleteCategory(int categoryId)
        {
            using (var connection = GetConnection())
            {
                var command = new SqlCommand("DELETE FROM Categories WHERE CategoryID = @CategoryID", connection);
                command.Parameters.AddWithValue("@CategoryID", categoryId);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<Category> GetCategoryList()
        {
            var categories = new List<Category>();
            using (var connection = GetConnection())
            {
                var command = new SqlCommand("SELECT * FROM Categories Order By CategoryName", connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var categoryObj = new Category
                        {
                            CategoryID = (int)reader["CategoryID"],
                            CategoryName = (string)reader["CategoryName"]
                        };
                        categories.Add(categoryObj);
                    }
                }
            }
            return categories;
        }
    }

}
