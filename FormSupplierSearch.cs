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
    public partial class FormSupplierSearch : Form
    {
        public DALSuppliers DALSupplierObj;
        public FormSupplierSearch()
        {
            InitializeComponent();

            DALSupplierObj = new DALSuppliers(MyConnectioString.Value);
            dataGridViewSupplier.AutoGenerateColumns = false;
        }

        private void FormUserSearch_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            // Show all records to gridview
            dataGridViewSupplier.DataSource = DALSupplierObj.GetSupplierList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormSupplierAddEdit FormSupplierAddEditObj = new FormSupplierAddEdit(0);
            FormSupplierAddEditObj.ShowDialog();

            LoadData();
        }

        private void dataGridViewSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgcEdit.Index || e.ColumnIndex == dgcDelete.Index)
            {
                int SupplierId = Convert.ToInt32(dataGridViewSupplier.CurrentRow.Cells[dgcSupplierID.Name].Value);

                if (e.ColumnIndex == dgcEdit.Index)
                {
                    // Edit record
                    FormSupplierAddEdit FormObj = new FormSupplierAddEdit(SupplierId);
                    FormObj.ShowDialog();
                }
                else if (e.ColumnIndex == dgcDelete.Index)
                {
                    if (MessageBox.Show("Do you want to Delete this record ?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        // Delete record.
                        DALSupplierObj.DeleteSupplier(SupplierId);
                    }
                }

                LoadData();
            }
        }
    }
}
