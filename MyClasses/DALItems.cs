using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WinBookStationaryStock19.MyClasses
{
    public class DALItems : DatabaseConnection
    {
        public DALItems(string connectionString) : base(connectionString) { }

        public void AddItem(Item item)
        {
            using (var connection = GetConnection())
            {
                var command = new SqlCommand("INSERT INTO Items (ItemName, CategoryID, Quantity, ReorderPoint, DPPrice, MRPPrice) VALUES (@ItemName, @CategoryID, @Quantity, @ReorderPoint, @DPPrice, @MRPPrice)", connection);
                command.Parameters.AddWithValue("@ItemName", item.ItemName);
                command.Parameters.AddWithValue("@CategoryID", item.CategoryID);
                command.Parameters.AddWithValue("@Quantity", item.Quantity);
                command.Parameters.AddWithValue("@ReorderPoint", item.ReorderPoint);
                command.Parameters.AddWithValue("@DPPrice", item.DPPrice);
                command.Parameters.AddWithValue("@MRPPrice", item.MRPPrice);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public Item GetItemById(int itemId)
        {
            using (var connection = GetConnection())
            {
                var command = new SqlCommand("SELECT * FROM Items WHERE ItemID = @ItemID", connection);
                command.Parameters.AddWithValue("@ItemID", itemId);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Item
                        {
                            ItemID = (int)reader["ItemID"],
                            ItemName = (string)reader["ItemName"],
                            CategoryID = (int)reader["CategoryID"],
                            Quantity = (int)reader["Quantity"],
                            ReorderPoint = (int)reader["ReorderPoint"],
                            DPPrice = (decimal)reader["DPPrice"],
                            MRPPrice = (decimal)reader["MRPPrice"]
                        };
                    }
                }
            }
            return null;
        }

        public void UpdateItem(Item item)
        {
            using (var connection = GetConnection())
            {
                var command = new SqlCommand("UPDATE Items SET ItemName = @ItemName, CategoryID = @CategoryID, Quantity = @Quantity, ReorderPoint = @ReorderPoint, DPPrice = @DPPrice, MRPPrice = @MRPPrice WHERE ItemID = @ItemID", connection);
                command.Parameters.AddWithValue("@ItemID", item.ItemID);
                command.Parameters.AddWithValue("@ItemName", item.ItemName);
                command.Parameters.AddWithValue("@CategoryID", item.CategoryID);
                command.Parameters.AddWithValue("@Quantity", item.Quantity);
                command.Parameters.AddWithValue("@ReorderPoint", item.ReorderPoint);
                command.Parameters.AddWithValue("@DPPrice", item.DPPrice);
                command.Parameters.AddWithValue("@MRPPrice", item.MRPPrice);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeleteItem(int itemId)
        {
            using (var connection = GetConnection())
            {
                var command = new SqlCommand("DELETE FROM Items WHERE ItemID = @ItemID", connection);
                command.Parameters.AddWithValue("@ItemID", itemId);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<Item> GetItemList()
        {
            var items = new List<Item>();
            using (var connection = GetConnection())
            {
                string myQuery = "SELECT I.*,C.CategoryName,C.CategoryName + ' ' + I.ItemName AS FullItemName "+
                    "FROM Items I Join Categories C On I.CategoryID = C.CategoryID Order By FullItemName";

                var command = new SqlCommand(myQuery, connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var itemObj = new Item
                        {
                            ItemID = (int)reader["ItemID"],
                            ItemName = (string)reader["ItemName"],
                            CategoryID = (int)reader["CategoryID"],
                            Quantity = (int)reader["Quantity"],
                            ReorderPoint = (int)reader["ReorderPoint"],
                            DPPrice = (decimal)reader["DPPrice"],
                            MRPPrice = (decimal)reader["MRPPrice"],
                            CategoryName = (string)reader["CategoryName"],
                            FullItemName = (string)reader["FullItemName"]
                        };
                        items.Add(itemObj);
                    }
                }
            }
            return items;
        }

        public List<ItemStock> GetItemStock()
        {
            var items = new List<ItemStock>();
            using (var connection = GetConnection())
            {
                string sqlQuery = "Select I.ItemID,c.CategoryName+' '+ I.ItemName as ItemFullName," +
                 "I.Quantity,I.ReorderPoint,COALESCE(OT.OrderQuantity,0) OrderQuantity,"+
                 "COALESCE(ST.SaleQuantity,0) SaleQuantity," +
                 "I.Quantity+COALESCE(OT.OrderQuantity,0)-COALESCE(ST.SaleQuantity,0) As StockQuantity " +
                 "From Items I " +
                 "Join Categories C on I.CategoryID = C.CategoryID " +
                 "Left Outer Join " +
                 "(Select ItemID, Sum(Quantity) As OrderQuantity From SupplierOrderDetails Group By ItemID) OT " +
                 "on I.ItemID = OT.ItemID " +
                 "Left Outer Join " +
                 "(Select ItemID, Sum(Quantity) As SaleQuantity From SaleDetails Group By ItemID) ST " +
                 "on I.ItemID = ST.ItemID";

                var command = new SqlCommand(sqlQuery, connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var itemObj = new ItemStock
                        {
                            ItemID = (int)reader["ItemID"],
                            ItemFullName = (string)reader["ItemFullName"],
                            Quantity = (int)reader["Quantity"],
                            ReorderPoint = (int)reader["ReorderPoint"],
                            OrderQuantity = (int)reader["OrderQuantity"],
                            SaleQuantity = (int)reader["SaleQuantity"],
                            StockQuantity = (int)reader["StockQuantity"]
                        };
                        items.Add(itemObj);
                    }
                }
            }
            return items;
        }
    }

}
