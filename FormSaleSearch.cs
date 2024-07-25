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

namespace WinBookStationaryStock19
{
    public partial class FormSaleSearch : Form
    {
        public DALSales DALSaleObj;
        public DALCustomers DALCustomerObj;
        public FormSaleSearch()
        {
            InitializeComponent();

            DALSaleObj = new DALSales(MyConnectioString.Value);
            DALCustomerObj = new DALCustomers(MyConnectioString.Value);
            dataGridViewSales.AutoGenerateColumns = false;
        }

        private void FormUserSearch_Load(object sender, EventArgs e)
        {
            dgcCustomerID.DataSource = DALCustomerObj.GetCustomerList();
            dgcCustomerID.DisplayMember = "CustomerName";
            dgcCustomerID.ValueMember = "CustomerId";

            LoadData();
        }

        private void LoadData()
        {
            // Show all records to gridview
            dataGridViewSales.DataSource = DALSaleObj.GetAllSales();
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormSale FormObj = new FormSale(0);
            FormObj.ShowDialog();

            LoadData();
        }

        private void dataGridViewSales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgcEdit.Index || e.ColumnIndex == dgcDelete.Index)
            {
                int SaleId = Convert.ToInt32(dataGridViewSales.CurrentRow.Cells[dgcSaleID.Name].Value);

                if (e.ColumnIndex == dgcEdit.Index)
                {
                    // Edit record
                    FormSale FormObj = new FormSale(SaleId);
                    FormObj.ShowDialog();
                }
                else if (e.ColumnIndex == dgcDelete.Index)
                {
                    if (MessageBox.Show("Do you want to Delete this record ?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        // Delete record.
                        DALSaleObj.DeleteSale(SaleId);
                    }
                }

                LoadData();
            }
        }

        private void buttonPrintBill_Click(object sender, EventArgs e)
        {
            int SaleId = (int)dataGridViewSales.CurrentRow.Cells[dgcSaleID.Name].Value;
            Reports.FormReportBill RptObj = new Reports.FormReportBill(SaleId);
            RptObj.ShowDialog();
        }
    }
}
