using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinBookStationaryStock19.Reports;

namespace WinBookStationaryStock19
{
    public partial class FormMDI : Form
    {
        public FormMDI()
        {
            InitializeComponent();

            this.Text = Properties.Settings.Default.ProjectName;
        }

        private void FormMDI_Load(object sender, EventArgs e)
        {

        }

        private void mnuShopDetails_Click(object sender, EventArgs e)
        {
            FormShopDetails FormShopDetailsObj = new FormShopDetails();
            FormShopDetailsObj.ShowDialog();
        }

        private void mnuUsers_Click(object sender, EventArgs e)
        {
            FormUserSearch FormUserSearchObj = new FormUserSearch();
            FormUserSearchObj.ShowDialog();
        }

        private void mnuCategory_Click(object sender, EventArgs e)
        {
            FormCategorySearch FormCategorySearchObj = new FormCategorySearch();
            FormCategorySearchObj.ShowDialog();
        }

        private void mnuCustomer_Click(object sender, EventArgs e)
        {
            FormCustomerSearch FormCustomerSearchObj = new FormCustomerSearch();
            FormCustomerSearchObj.ShowDialog();
        }

        private void mnuSupplier_Click(object sender, EventArgs e)
        {
            FormSupplierSearch FormSupplierSearchObj = new FormSupplierSearch();
            FormSupplierSearchObj.ShowDialog();
        }

        private void mnuItem_Click(object sender, EventArgs e)
        {
            FormItemSearch FormObj = new FormItemSearch();
            FormObj.ShowDialog();
        }

        private void mnuSupplierOrder_Click(object sender, EventArgs e)
        {
            FormSupplierOrderSearch FormObj = new FormSupplierOrderSearch();
            FormObj.ShowDialog();
        }

        private void mnuSale_Click(object sender, EventArgs e)
        {
            FormSaleSearch FormObj = new FormSaleSearch();
            FormObj.ShowDialog();
        }

        private void mnuReports_Click(object sender, EventArgs e)
        {
            FormReport FormObj = new FormReport();
            FormObj.ShowDialog();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit this application ?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }

        private void mnuRptCustomerList_Click(object sender, EventArgs e)
        {
            FormReportCustomerList FormObj = new FormReportCustomerList();
            FormObj.ShowDialog();
        }

        private void mnuRptSupplierList_Click(object sender, EventArgs e)
        {
            FormReportSupplierList FormObj = new FormReportSupplierList();
            FormObj.ShowDialog();
        }

        private void mnuSupplierOrderReport_Click(object sender, EventArgs e)
        {
            FormReportMonthlySupplierOrder FormObj = new FormReportMonthlySupplierOrder();
            FormObj.ShowDialog();
        }

        private void mnuSaleReport_Click(object sender, EventArgs e)
        {
            FormReportMonthlySale FormObj = new FormReportMonthlySale();
            FormObj.ShowDialog();
        }

        private void mnuItemStock_Click(object sender, EventArgs e)
        {
            FormReportStock FormObj = new FormReportStock();
            FormObj.ShowDialog();
        }

        private void mnuProfitReport_Click(object sender, EventArgs e)
        {
            FormReportProfit FormObj = new FormReportProfit();
            FormObj.ShowDialog();
        }
    }
}
