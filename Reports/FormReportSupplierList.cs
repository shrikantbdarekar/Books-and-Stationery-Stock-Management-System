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
    public partial class FormReportSupplierList : Form
    {
        public FormReportSupplierList()
        {
            InitializeComponent();
        }

        private void FormReportSupplierList_Load(object sender, EventArgs e)
        {
            DALShopDetails DALShopDetail = new DALShopDetails(MyConnectioString.Value);
            DALSuppliers DALSupplierObj = new DALSuppliers(MyConnectioString.Value);

            ShopDetail ShopDetailObj = DALShopDetail.GetShopDetailById(Properties.Settings.Default.ShopId);
            List<Supplier> suppliers = DALSupplierObj.GetSupplierList();

            CrystalReportSupplierList rptObj = new CrystalReportSupplierList();
            // First: set DataSource for report document
            rptObj.SetDataSource(suppliers);
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
