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
    public partial class FormUserAddEdit : Form
    {
        private int UserID;
        private User UserObj;
        private DALUsers DALUserObj;
        public FormUserAddEdit(int UserId)
        {
            InitializeComponent();

            this.UserID = UserId;

            UserObj = new User();
            DALUserObj = new DALUsers(MyConnectioString.Value);
        }

        private void FormUserAddEdit_Load(object sender, EventArgs e)
        {
            if (UserID != 0)
            {
                UserObj = DALUserObj.GetUserById(UserID);

                textBoxUserName.Text = UserObj.Username;
                textBoxPassword.Text = UserObj.UserPassword;
                comboBoxRole.Text = UserObj.UserRole;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                UserObj.Username = textBoxUserName.Text;
                UserObj.UserPassword = textBoxPassword.Text;
                UserObj.UserRole = comboBoxRole.Text;

                if (UserID == 0)
                {
                    DALUserObj.AddUser(UserObj);
                }
                else
                {
                    DALUserObj.UpdateUser(UserObj);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
