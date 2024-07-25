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
    public partial class FormCustomerAddEdit : Form
    {
        private int CustomerID;
        private Customer CustomerObj;
        private DALCustomers DALCustomerObj;
        public FormCustomerAddEdit(int CustomerID)
        {
            InitializeComponent();

            this.CustomerID = CustomerID;

            CustomerObj = new Customer();
            DALCustomerObj = new DALCustomers(MyConnectioString.Value);
        }

        private void FormCustomerAddEdit_Load(object sender, EventArgs e)
        {
            if (CustomerID != 0)
            {
                CustomerObj = DALCustomerObj.GetCustomerById(CustomerID);

                textBoxCustomerName.Text = CustomerObj.CustomerName;
                textBoxCustomerAddress.Text = CustomerObj.CustomerAddress;
                textBoxContactNo.Text = CustomerObj.ContactNo;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerObj.CustomerName= textBoxCustomerName.Text;
                 CustomerObj.CustomerAddress= textBoxCustomerAddress.Text;
                 CustomerObj.ContactNo= textBoxContactNo.Text;

                if (CustomerID == 0)
                {
                    DALCustomerObj.AddCustomer(CustomerObj);
                }
                else
                {
                    DALCustomerObj.UpdateCustomer(CustomerObj);
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
