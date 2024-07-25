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
    public partial class FormReportProfit : Form
    {
        //private DALSuppliers DALSupplier;
        //private DALSupplierOrders DALSupplierOrder;
        //private DALSupplierOrderDetails DALSupplierOrderDetail;
        private DALShopDetails DALShopDetail;
        public FormReportProfit()
        {
            InitializeComponent();
        }

        private void FormReportProfit_Load(object sender, EventArgs e)
        {

            //DALSupplier = new DALSuppliers(MyConnectioString.Value);
            //DALSupplierOrder = new DALSupplierOrders(MyConnectioString.Value);
            //DALSupplierOrderDetail = new DALSupplierOrderDetails(MyConnectioString.Value);
            DALShopDetail = new DALShopDetails(MyConnectioString.Value);
        }

        private void buttonShowReport_Click(object sender, EventArgs e)
        {
            DateTime FromDate = dateTimePickerFromDate.Value;
            DateTime ToDate = dateTimePickerToDate.Value;

            decimal SaleAmount = 0, OrderCost = 0, ProfitAmount = 0;

            ShopDetail ShopDetailObj = DALShopDetail.GetShopDetailById(Properties.Settings.Default.ShopId);
            //List<SupplierOrder> SupplierOrderList = DALSupplierOrder.GetMonthlySupplierOrderList(FromDate, ToDate);
            //List<Supplier> SupplierList = DALSupplier.GetSupplierList();

            //BillReportDataTable BillReportDataTableObj = new BillReportDataTable();
            //DataSet dsObj = new DataSet("DataSetBookStationaryDB");

            //DataTable dtSupplierOrder = BillReportDataTableObj.DTSupplierOrders;
            //DataTable dtSuppliers = BillReportDataTableObj.DTSuppliers;

            //// Adding a row to the DataTable Sale
            //foreach (var supplierOrderObj in SupplierOrderList)
            //{
            //    dtSupplierOrder.Rows.Add(supplierOrderObj.OrderID, supplierOrderObj.SupplierID, supplierOrderObj.OrderNo, supplierOrderObj.OrderDate, supplierOrderObj.TotalAmount);
            //}

            //// Adding a row to the DataTable Customers
            //foreach (var supplierObj in SupplierList)
            //{
            //    dtSuppliers.Rows.Add(supplierObj.SupplierID, supplierObj.SupplierName, supplierObj.ContactNo, supplierObj.SupplierAddress);
            //}

            //dsObj.Tables.Add(dtSupplierOrder.Copy());
            //dsObj.Tables.Add(dtSuppliers.Copy());

            // Read values from database
            SaleAmount = 36000; OrderCost = 22000;ProfitAmount = 14000;

            CrystalReportProfit rptObj = new CrystalReportProfit();

            //// First: set DataSource for report document
            //rptObj.SetDataSource(dsObj);

            // Second: Add values for report parameters.
            rptObj.ParameterFields["ShopName"].CurrentValues.AddValue(ShopDetailObj.ShopName);
            rptObj.ParameterFields["ShopAddress"].CurrentValues.AddValue(ShopDetailObj.ShopAddress);
            rptObj.ParameterFields["MobileNo"].CurrentValues.AddValue(ShopDetailObj.MobileNo);
            rptObj.ParameterFields["Email"].CurrentValues.AddValue(ShopDetailObj.Email);
            rptObj.ParameterFields["Website"].CurrentValues.AddValue(ShopDetailObj.Website);
            rptObj.ParameterFields["FromDate"].CurrentValues.AddValue(FromDate);
            rptObj.ParameterFields["ToDate"].CurrentValues.AddValue(ToDate);

            rptObj.ParameterFields["TotalSale"].CurrentValues.AddValue(SaleAmount);
            rptObj.ParameterFields["OrderCost"].CurrentValues.AddValue(OrderCost);
            rptObj.ParameterFields["ProfitAmount"].CurrentValues.AddValue(ProfitAmount);

            crystalReportViewerMain.ReportSource = rptObj;
        }
    }
}
