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
    public partial class FormReportCustomerList : Form
    {
        public FormReportCustomerList()
        {
            InitializeComponent();
        }

        private void FormReportCustomerList_Load(object sender, EventArgs e)
        {
            DALShopDetails DALShopDetail = new DALShopDetails(MyConnectioString.Value);
            DALCustomers DALCustomerObj = new DALCustomers(MyConnectioString.Value);

            ShopDetail ShopDetailObj = DALShopDetail.GetShopDetailById(Properties.Settings.Default.ShopId);
            List<Customer> customers = DALCustomerObj.GetCustomerList();

            //DataSetBookStationaryDB.CustomersDataTable dtObj = new DataSetBookStationaryDB.CustomersDataTable();

            //foreach (var customerObj in customers)
            //{
            //    dtObj.AddCustomersRow(customerObj.CustomerID, customerObj.CustomerName, customerObj.ContactNo, customerObj.CustomerAddress);
            //}

            CrystalReportCustomerList rptObj = new CrystalReportCustomerList();
            // First: set DataSource for report document
            rptObj.SetDataSource(customers);
            // Second: Add values for report parameters.
            rptObj.ParameterFields["ShopName"].CurrentValues.AddValue(ShopDetailObj.ShopName);
            rptObj.ParameterFields["ShopAddress"].CurrentValues.AddValue(ShopDetailObj.ShopAddress);
            rptObj.ParameterFields["MobileNo"].CurrentValues.AddValue(ShopDetailObj.MobileNo);
            rptObj.ParameterFields["Email"].CurrentValues.AddValue(ShopDetailObj.Email);
            rptObj.ParameterFields["Website"].CurrentValues.AddValue(ShopDetailObj.Website);
            
            crystalReportViewerMain.ReportSource = rptObj;
        }
    }
}
