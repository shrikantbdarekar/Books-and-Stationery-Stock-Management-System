using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WinBookStationaryStock19.MyClasses
{
    public class DALShopDetails : DatabaseConnection
    {
        public DALShopDetails(string connectionString) : base(connectionString) { }

        public void AddShopDetail(ShopDetail shopDetail)
        {
            using (var connection = GetConnection())
            {
                var command = new SqlCommand("INSERT INTO ShopDetails (ShopName, ShopAddress, MobileNo, Email, Website) VALUES (@ShopName, @ShopAddress, @MobileNo, @Email, @Website)", connection);
                command.Parameters.AddWithValue("@ShopName", shopDetail.ShopName);
                command.Parameters.AddWithValue("@ShopAddress", shopDetail.ShopAddress);
                command.Parameters.AddWithValue("@MobileNo", shopDetail.MobileNo);
                command.Parameters.AddWithValue("@Email", shopDetail.Email);
                command.Parameters.AddWithValue("@Website", shopDetail.Website);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public ShopDetail GetShopDetailById(int shopId)
        {
            using (var connection = GetConnection())
            {
                var command = new SqlCommand("SELECT * FROM ShopDetails WHERE ShopID = @ShopID", connection);
                command.Parameters.AddWithValue("@ShopID", shopId);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new ShopDetail
                        {
                            ShopID = (int)reader["ShopID"],
                            ShopName = (string)reader["ShopName"],
                            ShopAddress = (string)reader["ShopAddress"],
                            MobileNo = reader["MobileNo"] as string,
                            Email = reader["Email"] as string,
                            Website = reader["Website"] as string
                        };
                    }
                }
            }
            return null;
        }

        public void UpdateShopDetail(ShopDetail shopDetail)
        {
            using (var connection = GetConnection())
            {
                var command = new SqlCommand("UPDATE ShopDetails SET ShopName = @ShopName, ShopAddress = @ShopAddress, MobileNo = @MobileNo, Email = @Email, Website = @Website WHERE ShopID = @ShopID", connection);
                command.Parameters.AddWithValue("@ShopID", shopDetail.ShopID);
                command.Parameters.AddWithValue("@ShopName", shopDetail.ShopName);
                command.Parameters.AddWithValue("@ShopAddress", shopDetail.ShopAddress);
                command.Parameters.AddWithValue("@MobileNo", shopDetail.MobileNo);
                command.Parameters.AddWithValue("@Email", shopDetail.Email);
                command.Parameters.AddWithValue("@Website", shopDetail.Website);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeleteShopDetail(int shopId)
        {
            using (var connection = GetConnection())
            {
                var command = new SqlCommand("DELETE FROM ShopDetails WHERE ShopID = @ShopID", connection);
                command.Parameters.AddWithValue("@ShopID", shopId);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<ShopDetail> GetAllShopDetails()
        {
            var shopDetails = new List<ShopDetail>();
            using (var connection = GetConnection())
            {
                var command = new SqlCommand("SELECT * FROM ShopDetails", connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var shopDetail = new ShopDetail
                        {
                            ShopID = (int)reader["ShopID"],
                            ShopName = (string)reader["ShopName"],
                            ShopAddress = (string)reader["ShopAddress"],
                            MobileNo = reader["MobileNo"] as string,
                            Email = reader["Email"] as string,
                            Website = reader["Website"] as string
                        };
                        shopDetails.Add(shopDetail);
                    }
                }
            }
            return shopDetails;
        }
    }

}
