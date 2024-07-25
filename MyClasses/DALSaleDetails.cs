using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WinBookStationaryStock19.MyClasses
{
    public class DALSaleDetails : DatabaseConnection
    {
        public DALSaleDetails(string connectionString) : base(connectionString) { }

        public void AddSaleDetail(SaleDetail saleDetail)
        {
            using (var connection = GetConnection())
            {
                var command = new SqlCommand("INSERT INTO SaleDetails (SaleID, ItemID, Quantity, Price) VALUES (@SaleID, @ItemID, @Quantity, @Price)", connection);
                command.Parameters.AddWithValue("@SaleID", saleDetail.SaleID);
                command.Parameters.AddWithValue("@ItemID", saleDetail.ItemID);
                command.Parameters.AddWithValue("@Quantity", saleDetail.Quantity);
                command.Parameters.AddWithValue("@Price", saleDetail.Price);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public SaleDetail GetSaleDetailById(int saleDetailId)
        {
            using (var connection = GetConnection())
            {
                var command = new SqlCommand("SELECT * FROM SaleDetails WHERE SaleDetailID = @SaleDetailID", connection);
                command.Parameters.AddWithValue("@SaleDetailID", saleDetailId);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new SaleDetail
                        {
                            SaleDetailID = (int)reader["SaleDetailID"],
                            SaleID = (int)reader["SaleID"],
                            ItemID = (int)reader["ItemID"],
                            Quantity = (int)reader["Quantity"],
                            Price = (decimal)reader["Price"]
                        };
                    }
                }
            }
            return null;
        }

        public void UpdateSaleDetail(SaleDetail saleDetail)
        {
            using (var connection = GetConnection())
            {
                var command = new SqlCommand("UPDATE SaleDetails SET SaleID = @SaleID, ItemID = @ItemID, Quantity = @Quantity, Price = @Price WHERE SaleDetailID = @SaleDetailID", connection);
                command.Parameters.AddWithValue("@SaleDetailID", saleDetail.SaleDetailID);
                command.Parameters.AddWithValue("@SaleID", saleDetail.SaleID);
                command.Parameters.AddWithValue("@ItemID", saleDetail.ItemID);
                command.Parameters.AddWithValue("@Quantity", saleDetail.Quantity);
                command.Parameters.AddWithValue("@Price", saleDetail.Price);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeleteSaleDetail(int saleDetailId)
        {
            using (var connection = GetConnection())
            {
                var command = new SqlCommand("DELETE FROM SaleDetails WHERE SaleDetailID = @SaleDetailID", connection);
                command.Parameters.AddWithValue("@SaleDetailID", saleDetailId);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<SaleDetail> GetSaleDetailsBySaleId(int saleId)
        {
            var saleDetails = new List<SaleDetail>();
            using (var connection = GetConnection())
            {
                string sqlQuery = "SELECT D.*,C.CategoryName +' '+ I.ItemName as ItemFullName FROM SaleDetails D "+
                    "Join Items I On D.ItemId=I.ItemId "+
                    "Join Categories C On I.CategoryId=C.CategoryId " +
                    "WHERE SaleID = @SaleID";
                var command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@SaleID", saleId);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var saleDetail = new SaleDetail
                        {
                            SaleDetailID = (int)reader["SaleDetailID"],
                            SaleID = (int)reader["SaleID"],
                            ItemID = (int)reader["ItemID"],
                            Quantity = (int)reader["Quantity"],
                            Price = (decimal)reader["Price"],
                            ItemFullName=(string)reader["ItemFullName"]
                        };
                        saleDetails.Add(saleDetail);
                    }
                }
            }
            return saleDetails;
        }
    }

}
