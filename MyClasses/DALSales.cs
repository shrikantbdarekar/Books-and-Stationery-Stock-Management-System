using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WinBookStationaryStock19.MyClasses
{
    public class DALSales : DatabaseConnection
    {
        public DALSales(string connectionString) : base(connectionString) { }

        public int AddSale(Sale sale)
        {
            using (var connection = GetConnection())
            {
                var command = new SqlCommand("INSERT INTO Sales (SaleDate, BillNo, CustomerID, TotalAmount) VALUES (@SaleDate, @BillNo, @CustomerID, @TotalAmount);"+
                    " SELECT SCOPE_IDENTITY()", connection);
                command.Parameters.AddWithValue("@SaleDate", sale.SaleDate);
                command.Parameters.AddWithValue("@BillNo", sale.BillNo);
                command.Parameters.AddWithValue("@CustomerID", sale.CustomerID);
                command.Parameters.AddWithValue("@TotalAmount", sale.TotalAmount);
                connection.Open();
                sale.SaleID = Convert.ToInt32(command.ExecuteScalar());
                return sale.SaleID;
            }
        }

        public Sale GetSaleById(int saleId)
        {
            using (var connection = GetConnection())
            {
                var command = new SqlCommand("SELECT * FROM Sales WHERE SaleID = @SaleID", connection);
                command.Parameters.AddWithValue("@SaleID", saleId);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Sale
                        {
                            SaleID = (int)reader["SaleID"],
                            SaleDate = (DateTime)reader["SaleDate"],
                            CustomerID = (int)reader["CustomerID"],
                            BillNo = (int)reader["BillNo"],
                            TotalAmount = (decimal)reader["TotalAmount"]
                        };
                    }
                }
            }
            return null;
        }

        public void UpdateSale(Sale sale)
        {
            using (var connection = GetConnection())
            {
                var command = new SqlCommand("UPDATE Sales SET SaleDate = @SaleDate, CustomerID = @CustomerID, TotalAmount = @TotalAmount, BillNo=@BillNo WHERE SaleID = @SaleID", connection);
                command.Parameters.AddWithValue("@SaleID", sale.SaleID);
                command.Parameters.AddWithValue("@SaleDate", sale.SaleDate);
                command.Parameters.AddWithValue("@CustomerID", sale.CustomerID);
                command.Parameters.AddWithValue("@TotalAmount", sale.TotalAmount);
                command.Parameters.AddWithValue("@BillNo", sale.BillNo);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeleteSale(int saleId)
        {
            using (var connection = GetConnection())
            {
                var command = new SqlCommand("DELETE FROM Sales WHERE SaleID = @SaleID", connection);
                command.Parameters.AddWithValue("@SaleID", saleId);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<Sale> GetAllSales()
        {
            var sales = new List<Sale>();
            using (var connection = GetConnection())
            {
                var command = new SqlCommand("SELECT * FROM Sales", connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var sale = new Sale
                        {
                            SaleID = (int)reader["SaleID"],
                            SaleDate = (DateTime)reader["SaleDate"],
                            BillNo = (int)reader["BillNo"],
                            CustomerID = (int)reader["CustomerID"],
                            TotalAmount = (decimal)reader["TotalAmount"]
                        };
                        sales.Add(sale);
                    }
                }
            }
            return sales;
        }

        public List<Sale> GetMonthlySales(DateTime FromDate,DateTime ToDate)
        {
            var sales = new List<Sale>();
            using (var connection = GetConnection())
            {
                //string sqlQuery = "SELECT* FROM Sales " +
                //    "WHERE SaleDate BETWEEN @FromDate AND @ToDate";
                string sqlQuery = "SELECT* FROM Sales "+
                "WHERE SaleDate >= @FromDate AND SaleDate <= @ToDate";
                var command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@FromDate", FromDate);
                command.Parameters.AddWithValue("@ToDate", ToDate);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var sale = new Sale
                        {
                            SaleID = (int)reader["SaleID"],
                            SaleDate = (DateTime)reader["SaleDate"],
                            BillNo = (int)reader["BillNo"],
                            CustomerID = (int)reader["CustomerID"],
                            TotalAmount = (decimal)reader["TotalAmount"]
                        };
                        sales.Add(sale);
                    }
                }
            }
            return sales;
        }
        public int GetBillNo()
        {
            using (var connection = GetConnection())
            {
                try
                {
                    var command = new SqlCommand("Select Max(BillNo)+1 From Sales;", connection);
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
