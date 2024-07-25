using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WinBookStationaryStock19.MyClasses
{
    public class DALSupplierOrders : DatabaseConnection
    {
        public DALSupplierOrders(string connectionString) : base(connectionString) { }

        public int AddSupplierOrder(SupplierOrder order)
        {
            using (var connection = GetConnection())
            {
                var command = new SqlCommand("INSERT INTO SupplierOrders (SupplierID, OrderNo, OrderDate,TotalAmount) VALUES (@SupplierID, @OrderNo, @OrderDate,@TotalAmount);" +
                    "SELECT SCOPE_IDENTITY();", connection);
                command.Parameters.AddWithValue("@SupplierID", order.SupplierID);
                command.Parameters.AddWithValue("@OrderNo", order.OrderNo);
                command.Parameters.AddWithValue("@OrderDate", order.OrderDate);
                command.Parameters.AddWithValue("@TotalAmount", order.TotalAmount);

                connection.Open();
                
                // ExecuteScalar: This method is used to execute the command and retrieve the first column
                // of the first row in the result set.This will be the newly inserted ID.
                var insertedId = command.ExecuteScalar();

                // Convert insertedId to the appropriate data type if needed
                int newOrderId = Convert.ToInt32(insertedId);
                return newOrderId;
            }
        }

        public SupplierOrder GetSupplierOrderById(int orderId)
        {
            using (var connection = GetConnection())
            {
                string sqlQuery = "SELECT * FROM SupplierOrders WHERE OrderID = @OrderID";

                var command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@OrderID", orderId);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new SupplierOrder
                        {
                            OrderID = (int)reader["OrderID"],
                            SupplierID = (int)reader["SupplierID"],
                            OrderNo = (int)reader["OrderNo"],
                            OrderDate = (DateTime)reader["OrderDate"],
                            TotalAmount = (decimal)reader["TotalAmount"]
                        };
                    }
                }
            }
            return null;
        }

        public void UpdateSupplierOrder(SupplierOrder order)
        {
            using (var connection = GetConnection())
            {
                var command = new SqlCommand("UPDATE SupplierOrders SET SupplierID = @SupplierID, OrderNo = @OrderNo, OrderDate = @OrderDate, TotalAmount = @TotalAmount WHERE OrderID = @OrderID", connection);
                command.Parameters.AddWithValue("@OrderID", order.OrderID);
                command.Parameters.AddWithValue("@SupplierID", order.SupplierID);
                command.Parameters.AddWithValue("@OrderNo", order.OrderNo);
                command.Parameters.AddWithValue("@OrderDate", order.OrderDate);
                command.Parameters.AddWithValue("@TotalAmount", order.TotalAmount);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeleteSupplierOrder(int orderId)
        {
            using (var connection = GetConnection())
            {
                var command = new SqlCommand("DELETE FROM SupplierOrders WHERE OrderID = @OrderID", connection);
                command.Parameters.AddWithValue("@OrderID", orderId);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<SupplierOrder> GetSupplierOrderList()
        {
            var supplierOrders = new List<SupplierOrder>();
            using (var connection = GetConnection())
            {
                string myQuery = "SELECT O.*,S.SupplierName " +
                    "FROM SupplierOrders O Join Suppliers S On O.SupplierID = S.SupplierID";

                var command = new SqlCommand(myQuery, connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var orderObj = new SupplierOrder
                        {
                            OrderID = (int)reader["OrderID"],
                            SupplierID = (int)reader["SupplierID"],
                            OrderNo = (int)reader["OrderNo"],
                            OrderDate = (DateTime)reader["OrderDate"],
                            TotalAmount = (decimal)reader["TotalAmount"]
                            //SupplierName = (string)reader["SupplierName"],
                        };
                        supplierOrders.Add(orderObj);
                    }
                }
            }
            return supplierOrders;
        }

        public List<SupplierOrder> GetMonthlySupplierOrderList(DateTime FromDate,DateTime ToDate)
        {
            var supplierOrders = new List<SupplierOrder>();
            using (var connection = GetConnection())
            {
                string myQuery = "SELECT O.*,S.SupplierName " +
                    "FROM SupplierOrders O Join Suppliers S On O.SupplierID = S.SupplierID "+
                "WHERE OrderDate >= @FromDate AND OrderDate <= @ToDate";

                var command = new SqlCommand(myQuery, connection);
                command.Parameters.AddWithValue("@FromDate", FromDate);
                command.Parameters.AddWithValue("@ToDate", ToDate);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var orderObj = new SupplierOrder
                        {
                            OrderID = (int)reader["OrderID"],
                            SupplierID = (int)reader["SupplierID"],
                            OrderNo = (int)reader["OrderNo"],
                            OrderDate = (DateTime)reader["OrderDate"],
                            TotalAmount = (decimal)reader["TotalAmount"]
                            //SupplierName = (string)reader["SupplierName"]
                        };
                        supplierOrders.Add(orderObj);
                    }
                }
            }
            return supplierOrders;
        }

        public int GetOrderNo()
        {
            using (var connection = GetConnection())
            {
                try
                {
                    var command = new SqlCommand("Select Max(OrderNo)+1 From SupplierOrders;", connection);
                    connection.Open();
                    int billNo = Convert.ToInt32(command.ExecuteScalar());
                    return billNo;
                }
                catch (Exception)
                {
                    return 1;
                }
            }
        }
    }

}
