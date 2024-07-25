using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WinBookStationaryStock19.MyClasses
{
    public class DALCustomers : DatabaseConnection
    {
        public DALCustomers(string connectionString) : base(connectionString) { }

        public void AddCustomer(Customer customer)
        {
            using (var connection = GetConnection())
            {
                var command = new SqlCommand("INSERT INTO Customers (CustomerName, ContactNo, CustomerAddress) VALUES (@CustomerName, @ContactNo, @CustomerAddress)", connection);
                command.Parameters.AddWithValue("@CustomerName", customer.CustomerName);
                command.Parameters.AddWithValue("@ContactNo", customer.ContactNo);
                command.Parameters.AddWithValue("@CustomerAddress", customer.CustomerAddress);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public Customer GetCustomerById(int customerId)
        {
            using (var connection = GetConnection())
            {
                var command = new SqlCommand("SELECT * FROM Customers WHERE CustomerID = @CustomerID", connection);
                command.Parameters.AddWithValue("@CustomerID", customerId);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Customer
                        {
                            CustomerID = (int)reader["CustomerID"],
                            CustomerName = (string)reader["CustomerName"],
                            ContactNo = reader["ContactNo"] as string,
                            CustomerAddress = reader["CustomerAddress"] as string
                        };
                    }
                }
            }
            return null;
        }

        public void UpdateCustomer(Customer customer)
        {
            using (var connection = GetConnection())
            {
                var command = new SqlCommand("UPDATE Customers SET CustomerName = @CustomerName, ContactNo = @ContactNo, CustomerAddress = @CustomerAddress WHERE CustomerID = @CustomerID", connection);
                command.Parameters.AddWithValue("@CustomerID", customer.CustomerID);
                command.Parameters.AddWithValue("@CustomerName", customer.CustomerName);
                command.Parameters.AddWithValue("@ContactNo", customer.ContactNo);
                command.Parameters.AddWithValue("@CustomerAddress", customer.CustomerAddress);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeleteCustomer(int customerId)
        {
            using (var connection = GetConnection())
            {
                var command = new SqlCommand("DELETE FROM Customers WHERE CustomerID = @CustomerID", connection);
                command.Parameters.AddWithValue("@CustomerID", customerId);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<Customer> GetCustomerList()
        {
            var customers = new List<Customer>();
            using (var connection = GetConnection())
            {
                var command = new SqlCommand("SELECT * FROM Customers Order By CustomerName", connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var customerObj = new Customer
                        {
                            CustomerID = (int)reader["CustomerID"],
                            CustomerName = (string)reader["CustomerName"],
                            CustomerAddress = (string)reader["CustomerAddress"],
                            ContactNo = (string)reader["ContactNo"]
                        };
                        customers.Add(customerObj);
                    }
                }
            }
            return customers;
        }
    }

}
