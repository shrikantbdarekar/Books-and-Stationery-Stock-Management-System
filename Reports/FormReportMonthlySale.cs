using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinBookStationaryStock19.MyClasses;

namespace WinBookStationaryStock19.Reports
{
    public partial class FormReportMonthlySale : Form
    {
        private DALCustomers DALCustomer;
        private DALSales DALSale;
        private DALSaleDetails DALSaleDetail;
        private DALShopDetails DALShopDetail;
        public FormReportMonthlySale()
        {
            InitializeComponent();
        }

        private void FormReportMonthlySale_Load(object sender, EventArgs e)
        {
            DALCustomer = new DALCustomers(MyConnectioString.Value);
            DALSale = new DALSales(MyConnectioString.Value);
            DALSaleDetail = new DALSaleDetails(MyConnectioString.Value);
            DALShopDetail = new DALShopDetails(MyConnectioString.Value);
        }

        private void buttonShowReport_Click(object sender, EventArgs e)
        {
            DateTime FromDate = dateTimePickerFromDate.Value;
            DateTime ToDate = dateTimePickerToDate.Value;

            ShopDetail ShopDetailObj = DALShopDetail.GetShopDetailById(Properties.Settings.Default.ShopId);
            List<Sale> SaleList = DALSale.GetMonthlySales(FromDate, ToDate);
            List<Customer> CustomerList = DALCustomer.GetCustomerList();

            BillReportDataTable BillReportDataTableObj = new BillReportDataTable();
            DataSet dsObj = new DataSet("DataSetBookStationaryDB");

            DataTable dtSale = BillReportDataTableObj.DTSales;
            DataTable dtCustomers = BillReportDataTableObj.DTCustomers;

            // Adding a row to the DataTable Sale
            foreach (var saleObj in SaleList)
            {
                dtSale.Rows.Add(saleObj.SaleID, saleObj.BillNo, saleObj.SaleDate, saleObj.CustomerID, saleObj.TotalAmount);
            }

            // Adding a row to the DataTable Customers
            foreach (var customerObj in CustomerList)
            {
                dtCustomers.Rows.Add(customerObj.CustomerID, customerObj.CustomerName, customerObj.ContactNo, customerObj.CustomerAddress);
            }

            dsObj.Tables.Add(dtSale.Copy());
            dsObj.Tables.Add(dtCustomers.Copy());

            CrystalReportMonthlySale rptObj = new CrystalReportMonthlySale();
            
            // First: set DataSource for report document
            rptObj.SetDataSource(dsObj);
            // Second: Add values for report parameters.
            rptObj.ParameterFields["ShopName"].CurrentValues.AddValue(ShopDetailObj.ShopName);
            rptObj.ParameterFields["ShopAddress"].CurrentValues.AddValue(ShopDetailObj.ShopAddress);
            rptObj.ParameterFields["MobileNo"].CurrentValues.AddValue(ShopDetailObj.MobileNo);
            rptObj.ParameterFields["Email"].CurrentValues.AddValue(ShopDetailObj.Email);
            rptObj.ParameterFields["Website"].CurrentValues.AddValue(ShopDetailObj.Website);
            rptObj.ParameterFields["FromDate"].CurrentValues.AddValue(FromDate);
            rptObj.ParameterFields["ToDate"].CurrentValues.AddValue(ToDate);

            crystalReportViewerMain.ReportSource = rptObj;
        }

        public class BillReportDataTable
        {
            public DataTable DTSales
            {
                get
                {
                    DataTable dtSale = new DataTable("Sales");
                    dtSale.Columns.Add("SaleID", typeof(int));
                    dtSale.Columns.Add("BillNo", typeof(int));
                    dtSale.Columns.Add("SaleDate", typeof(DateTime));
                    dtSale.Columns.Add("CustomerID", typeof(int));
                    dtSale.Columns.Add("TotalAmount", typeof(decimal));
                    return dtSale.Copy();
                }
            }

            public DataTable DTSaleDetails
            {
                get
                {
                    DataTable dtSaleDetails = new DataTable("SaleDetails");
                    dtSaleDetails.Columns.Add("SaleDetailID", typeof(int));
                    dtSaleDetails.Columns.Add("SaleID", typeof(int));
                    dtSaleDetails.Columns.Add("ItemID", typeof(int));
                    dtSaleDetails.Columns.Add("Quantity", typeof(int));
                    dtSaleDetails.Columns.Add("Price", typeof(decimal));
                    dtSaleDetails.Columns.Add("ItemFullName", typeof(string));
                    return dtSaleDetails.Copy();
                }
            }

            public DataTable DTCustomers
            {
                get
                {
                    DataTable dtCustomers = new DataTable("Customers");
                    dtCustomers.Columns.Add("CustomerID", typeof(int));
                    dtCustomers.Columns.Add("CustomerName", typeof(string));
                    dtCustomers.Columns.Add("ContactNo", typeof(string));
                    dtCustomers.Columns.Add("CustomerAddress", typeof(string));
                    return dtCustomers.Copy();
                }
            }
        }
    }
}
