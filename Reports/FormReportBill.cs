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
    public partial class FormReportBill : Form
    {
        private int SaleId;
        public FormReportBill(int SaleId)
        {
            InitializeComponent();

            this.SaleId = SaleId;
        }

        private void FormReportBill_Load(object sender, EventArgs e)
        {
            DALCustomers DALCustomerObj = new DALCustomers(MyConnectioString.Value);
            DALSales DALSaleObj = new DALSales(MyConnectioString.Value);
            DALSaleDetails DALSaleDetailObj = new DALSaleDetails(MyConnectioString.Value);

            Sale SaleObj = DALSaleObj.GetSaleById(SaleId);
            List<SaleDetail> SaleDetailList = DALSaleDetailObj.GetSaleDetailsBySaleId(SaleObj.SaleID);
            Customer CustomerObj = DALCustomerObj.GetCustomerById(SaleObj.CustomerID);

            BillReportDataTable BillReportDataTableObj = new BillReportDataTable();
            DataSet dsObj = new DataSet("DataSetBookStationaryDB");
            
            DataTable dtSale = BillReportDataTableObj.DTSales;
            DataTable dtSaleDetails = BillReportDataTableObj.DTSaleDetails;
            DataTable dtCustomers = BillReportDataTableObj.DTCustomers;

            // Adding a row to the DataTable Sale
            dtSale.Rows.Add(SaleObj.SaleID, SaleObj.BillNo, SaleObj.SaleDate,SaleObj.CustomerID, SaleObj.TotalAmount);

            // Adding a row to the DataTable SaleDetails
            foreach (var saleDetailObj in SaleDetailList)
            {
                dtSaleDetails.Rows.Add(saleDetailObj.SaleDetailID, saleDetailObj.SaleID, saleDetailObj.ItemID, 
                    saleDetailObj.Quantity, saleDetailObj.Price,saleDetailObj.ItemFullName);
            }

            // Adding a row to the DataTable Customers
            dtCustomers.Rows.Add(CustomerObj.CustomerID, CustomerObj.CustomerName, CustomerObj.ContactNo, CustomerObj.CustomerAddress);

            dsObj.Tables.Add(dtSale.Copy());
            dsObj.Tables.Add(dtSaleDetails.Copy());
            dsObj.Tables.Add(dtCustomers.Copy());

            CrystalReportBill rptObj = new CrystalReportBill();
            rptObj.SetDataSource(dsObj);

            crystalReportViewerMain.ReportSource = rptObj;
        }

        public class BillReportDataTable
        {
            public DataTable DTSales {
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
