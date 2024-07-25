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
    public partial class FormReportStock : Form
    {
        public FormReportStock()
        {
            InitializeComponent();
        }

        private void FormReportStock_Load(object sender, EventArgs e)
        {
            DALShopDetails ShopDetail = new DALShopDetails(MyConnectioString.Value);
            DALItems DALItem = new DALItems(MyConnectioString.Value);

            ShopDetail ShopDetailObj = ShopDetail.GetShopDetailById(Properties.Settings.Default.ShopId);
            List<ItemStock> itemList = DALItem.GetItemStock();

            CrystalReportStock rptObj = new CrystalReportStock();
            // First: set DataSource for report document
            rptObj.SetDataSource(itemList);
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
