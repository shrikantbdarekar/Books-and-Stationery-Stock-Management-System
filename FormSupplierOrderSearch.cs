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
    public partial class FormSupplierOrderSearch : Form
    {
        public DALSupplierOrders DALSupplierOrderObj;
        public DALSuppliers DALSupplier;
        public FormSupplierOrderSearch()
        {
            InitializeComponent();

            DALSupplierOrderObj = new DALSupplierOrders(MyConnectioString.Value);
            DALSupplier = new DALSuppliers(MyConnectioString.Value);
            dataGridViewSupplierOrders.AutoGenerateColumns = false;
        }

        private void FormUserSearch_Load(object sender, EventArgs e)
        {
            dgcSupplierId.DataSource = DALSupplier.GetSupplierList();
            dgcSupplierId.DisplayMember = "SupplierName";
            dgcSupplierId.ValueMember = "SupplierId";

            LoadData();
        }

        private void LoadData()
        {
            // Show all records to gridview
            dataGridViewSupplierOrders.DataSource = DALSupplierOrderObj.GetSupplierOrderList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormSupplierOrder FormObj = new FormSupplierOrder(0);
            FormObj.ShowDialog();

            LoadData();
        }

        private void dataGridViewSupplierOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgcEdit.Index || e.ColumnIndex == dgcDelete.Index)
            {
                int OrderId = Convert.ToInt32(dataGridViewSupplierOrders.CurrentRow.Cells[dgcOrderID.Name].Value);

                if (e.ColumnIndex == dgcEdit.Index)
                {
                    // Edit record
                    FormSupplierOrder FormObj = new FormSupplierOrder(OrderId);
                    FormObj.ShowDialog();
                }
                else if (e.ColumnIndex == dgcDelete.Index)
                {
                    if (MessageBox.Show("Do you want to Delete this record ?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        // Delete record.
                        DALSupplierOrderObj.DeleteSupplierOrder(OrderId);
                    }
                }

                LoadData();
            }
        }
    }
}
