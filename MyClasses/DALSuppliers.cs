using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WinBookStationaryStock19.MyClasses
{
    public class DALSuppliers : DatabaseConnection
    {
        public DALSuppliers(string connectionString) : base(connectionString) { }

        public void AddSupplier(Supplier supplier)
        {
            using (var connection = GetConnection())
            {
                var command = new SqlCommand("INSERT INTO Suppliers (SupplierName, ContactNo, SupplierAddress) VALUES (@SupplierName, @ContactNo, @SupplierAddress)", connection);
                command.Parameters.AddWithValue("@SupplierName", supplier.SupplierName);
                command.Parameters.AddWithValue("@ContactNo", supplier.ContactNo);
                command.Parameters.AddWithValue("@SupplierAddress", supplier.SupplierAddress);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public Supplier GetSupplierById(int supplierId)
        {
            using (var connection = GetConnection())
            {
                var command = new SqlCommand("SELECT * FROM Suppliers WHERE SupplierID = @SupplierID", connection);
                command.Parameters.AddWithValue("@SupplierID", supplierId);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Supplier
                        {
                            SupplierID = (int)reader["SupplierID"],
                            SupplierName = (string)reader["SupplierName"],
                            ContactNo = reader["ContactNo"] as string,
                            SupplierAddress = reader["SupplierAddress"] as string
                        };
                    }
                }
            }
            return null;
        }

        public void UpdateSupplier(Supplier supplier)
        {
            using (var connection = GetConnection())
            {
                var command = new SqlCommand("UPDATE Suppliers SET SupplierName = @SupplierName, ContactNo = @ContactNo, SupplierAddress = @SupplierAddress WHERE SupplierID = @SupplierID", connection);
                command.Parameters.AddWithValue("@SupplierID", supplier.SupplierID);
                command.Parameters.AddWithValue("@SupplierName", supplier.SupplierName);
                command.Parameters.AddWithValue("@ContactNo", supplier.ContactNo);
                command.Parameters.AddWithValue("@SupplierAddress", supplier.SupplierAddress);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeleteSupplier(int supplierId)
        {
            using (var connection = GetConnection())
            {
                var command = new SqlCommand("DELETE FROM Suppliers WHERE SupplierID = @SupplierID", connection);
                command.Parameters.AddWithValue("@SupplierID", supplierId);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<Supplier> GetSupplierList()
        {
            var suppliers = new List<Supplier>();
            using (var connection = GetConnection())
            {
                var command = new SqlCommand("SELECT * FROM Suppliers Order By SupplierName", connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var supplierObj = new Supplier
                        {
                            SupplierID = (int)reader["SupplierID"],
                            SupplierName = (string)reader["SupplierName"],
                            SupplierAddress = (string)reader["SupplierAddress"],
                            ContactNo = (string)reader["ContactNo"]
                        };
                        suppliers.Add(supplierObj);
                    }
                }
            }
            return suppliers;
        }
    }

}
