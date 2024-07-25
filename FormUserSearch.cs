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
    public partial class FormUserSearch : Form
    {
        public DALUsers DALUserObj;
        public FormUserSearch()
        {
            InitializeComponent();

            DALUserObj = new DALUsers(MyConnectioString.Value);
            dataGridViewUsers.AutoGenerateColumns = false;
        }

        private void FormUserSearch_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            // Show all records to gridview
            dataGridViewUsers.DataSource = DALUserObj.GetUserList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormUserAddEdit FormUserAddEditObj = new FormUserAddEdit(0);
            FormUserAddEditObj.ShowDialog();

            LoadData();
        }

        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgcEdit.Index || e.ColumnIndex == dgcDelete.Index)
            {
                int UserId = Convert.ToInt32(dataGridViewUsers.CurrentRow.Cells[dgcUserId.Name].Value);

                if (e.ColumnIndex == dgcEdit.Index)
                {
                    // Edit record
                    FormUserAddEdit FormObj = new FormUserAddEdit(UserId);
                    FormObj.ShowDialog();
                }
                else if (e.ColumnIndex == dgcDelete.Index)
                {
                    if (MessageBox.Show("Do you want to Delete this record ?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        // Delete record.
                        DALUserObj.DeleteUser(UserId);
                    }
                }

                LoadData();
            }
        }
    }
}
