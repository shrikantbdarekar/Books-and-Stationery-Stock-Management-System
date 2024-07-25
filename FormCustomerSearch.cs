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
    public partial class FormCustomerSearch : Form
    {
        public DALCustomers DALCustomerObj;
        public FormCustomerSearch()
        {
            InitializeComponent();

            DALCustomerObj = new DALCustomers(MyConnectioString.Value);
            dataGridViewCustomers.AutoGenerateColumns = false;
        }

        private void FormUserSearch_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            // Show all records to gridview
            dataGridViewCustomers.DataSource = DALCustomerObj.GetCustomerList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormCustomerAddEdit FormCustomerAddEditObj = new FormCustomerAddEdit(0);
            FormCustomerAddEditObj.ShowDialog();

            LoadData();
        }

        private void dataGridViewCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgcEdit.Index || e.ColumnIndex == dgcDelete.Index)
            {
                int CustomerId = Convert.ToInt32(dataGridViewCustomers.CurrentRow.Cells[dgcCustomerId.Name].Value);

                if (e.ColumnIndex == dgcEdit.Index)
                {
                    // Edit record
                    FormCustomerAddEdit FormObj = new FormCustomerAddEdit(CustomerId);
                    FormObj.ShowDialog();
                }
                else if (e.ColumnIndex == dgcDelete.Index)
                {
                    if (MessageBox.Show("Do you want to Delete this record ?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        // Delete record.
                        DALCustomerObj.DeleteCustomer(CustomerId);
                    }
                }

                LoadData();
            }
        }
    }
}
