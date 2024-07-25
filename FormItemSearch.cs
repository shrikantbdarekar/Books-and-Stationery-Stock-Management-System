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
    public partial class FormItemSearch : Form
    {
        public DALItems DALItemObj;
        public FormItemSearch()
        {
            InitializeComponent();

            DALItemObj = new DALItems(MyConnectioString.Value);
            dataGridViewItems.AutoGenerateColumns = false;
        }

        private void FormUserSearch_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            // Show all records to gridview
            dataGridViewItems.DataSource = DALItemObj.GetItemList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormItemAddEdit FormObj = new FormItemAddEdit(0);
            FormObj.ShowDialog();

            LoadData();
        }

        private void dataGridViewItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgcEdit.Index || e.ColumnIndex == dgcDelete.Index)
            {
                int ItemId = Convert.ToInt32(dataGridViewItems.CurrentRow.Cells[dgcItemId.Name].Value);

                if (e.ColumnIndex == dgcEdit.Index)
                {
                    // Edit record
                    FormItemAddEdit FormObj = new FormItemAddEdit(ItemId);
                    FormObj.ShowDialog();
                }
                else if (e.ColumnIndex == dgcDelete.Index)
                {
                    if (MessageBox.Show("Do you want to Delete this record ?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        // Delete record.
                        DALItemObj.DeleteItem(ItemId);
                    }
                }

                LoadData();
            }
        }
    }
}
