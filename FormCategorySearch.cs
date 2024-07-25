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
    public partial class FormCategorySearch : Form
    {
        public DALCategories DALCategoriesObj;
        public FormCategorySearch()
        {
            InitializeComponent();

            DALCategoriesObj = new DALCategories(MyConnectioString.Value);
            dataGridViewCategories.AutoGenerateColumns = false;
        }

        private void FormUserSearch_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            // Show all records to gridview
            dataGridViewCategories.DataSource = DALCategoriesObj.GetCategoryList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormCategoryAddEdit FormCategoryAddEditObj = new FormCategoryAddEdit(0);
            FormCategoryAddEditObj.ShowDialog();

            LoadData();
        }

        private void dataGridViewCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ( e.ColumnIndex == dgcEdit.Index || e.ColumnIndex == dgcDelete.Index)
            {
                int CategoryId = Convert.ToInt32(dataGridViewCategories.CurrentRow.Cells[dgcCategoryId.Name].Value);

                if (e.ColumnIndex == dgcEdit.Index)
                {
                    // Edit record
                    FormCategoryAddEdit FormObj = new FormCategoryAddEdit(CategoryId);
                    FormObj.ShowDialog();
                }
                else if (e.ColumnIndex == dgcDelete.Index)
                {
                    if (MessageBox.Show("Do you want to Delete this record ?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        // Delete record.
                        DALCategoriesObj.DeleteCategory(CategoryId);
                    }
                }

                LoadData();
            }
        }
    }
}
