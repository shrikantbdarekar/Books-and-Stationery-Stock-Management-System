using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WinBookStationaryStock19.MyClasses
{
    public class DALSupplierOrderDetails : DatabaseConnection
    {
        public DALSupplierOrderDetails(string connectionString) : base(connectionString) { }

        public void AddSupplierOrderDetail(SupplierOrderDetail orderDetail)
        {
            using (var connection = GetConnection())
            {
                var command = new SqlCommand("INSERT INTO SupplierOrderDetails (OrderID, ItemID, Quantity, PurchasePrice) VALUES (@OrderID, @ItemID, @Quantity, @PurchasePrice)", connection);
                command.Parameters.AddWithValue("@OrderID", orderDetail.OrderID);
                command.Parameters.AddWithValue("@ItemID", orderDetail.ItemID);
                command.Parameters.AddWithValue("@Quantity", orderDetail.Quantity);
                command.Parameters.AddWithValue("@PurchasePrice", orderDetail.PurchasePrice);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public SupplierOrderDetail GetSupplierOrderDetailById(int orderDetailId)
        {
            using (var connection = GetConnection())
            {
                var command = new SqlCommand("SELECT * FROM SupplierOrderDetails WHERE OrderDetailID = @OrderDetailID", connection);
                command.Parameters.AddWithValue("@OrderDetailID", orderDetailId);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new SupplierOrderDetail
                        {
                            OrderDetailID = (int)reader["OrderDetailID"],
                            OrderID = (int)reader["OrderID"],
                            ItemID = (int)reader["ItemID"],
                            Quantity = (int)reader["Quantity"],
                            PurchasePrice = (decimal)reader["PurchasePrice"]
                        };
                    }
                }
            }
            return null;
        }

        public void UpdateSupplierOrderDetail(SupplierOrderDetail orderDetail)
        {
            using (var connection = GetConnection())
            {
                var command = new SqlCommand("UPDATE SupplierOrderDetails SET OrderID = @OrderID, ItemID = @ItemID, Quantity = @Quantity, PurchasePrice = @PurchasePrice WHERE OrderDetailID = @OrderDetailID", connection);
                command.Parameters.AddWithValue("@OrderDetailID", orderDetail.OrderDetailID);
                command.Parameters.AddWithValue("@OrderID", orderDetail.OrderID);
                command.Parameters.AddWithValue("@ItemID", orderDetail.ItemID);
                command.Parameters.AddWithValue("@Quantity", orderDetail.Quantity);
                command.Parameters.AddWithValue("@PurchasePrice", orderDetail.PurchasePrice);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeleteSupplierOrderDetail(int orderDetailId)
        {
            using (var connection = GetConnection())
            {
                var command = new SqlCommand("DELETE FROM SupplierOrderDetails WHERE OrderDetailID = @OrderDetailID", connection);
                command.Parameters.AddWithValue("@OrderDetailID", orderDetailId);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<SupplierOrderDetail> GetSupplierOrderDetailsByOrderId(int orderId)
        {
            var orderDetails = new List<SupplierOrderDetail>();
            using (var connection = GetConnection())
            {
                var command = new SqlCommand("SELECT * FROM SupplierOrderDetails WHERE OrderID = @OrderID", connection);
                command.Parameters.AddWithValue("@OrderID", orderId);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var orderDetail = new SupplierOrderDetail
                        {
                            OrderDetailID = (int)reader["OrderDetailID"],
                            OrderID = (int)reader["OrderID"],
                            ItemID = (int)reader["ItemID"],
                            Quantity = (int)reader["Quantity"],
                            PurchasePrice = (decimal)reader["PurchasePrice"]
                        };
                        orderDetails.Add(orderDetail);
                    }
                }
            }
            return orderDetails;
        }


    }

}
