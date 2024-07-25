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
    public partial class FormSupplierAddEdit : Form
    {
        private int SupplierID;
        private Supplier SupplierObj;
        private DALSuppliers DALSupplierObj;
        public FormSupplierAddEdit(int SupplierID)
        {
            InitializeComponent();

            this.SupplierID = SupplierID;

            SupplierObj = new Supplier();
            DALSupplierObj = new DALSuppliers(MyConnectioString.Value);
        }

        private void FormSupplierAddEdit_Load(object sender, EventArgs e)
        {
            if (SupplierID != 0)
            {
                SupplierObj = DALSupplierObj.GetSupplierById(SupplierID);

                textBoxSupplierName.Text = SupplierObj.SupplierName;
                textBoxSupplierAddress.Text = SupplierObj.SupplierAddress;
                textBoxContactNo.Text = SupplierObj.ContactNo;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                SupplierObj.SupplierName = textBoxSupplierName.Text;
                SupplierObj.SupplierAddress = textBoxSupplierAddress.Text;
                SupplierObj.ContactNo = textBoxContactNo.Text;

                if (SupplierID == 0)
                {
                    DALSupplierObj.AddSupplier(SupplierObj);
                }
                else
                {
                    DALSupplierObj.UpdateSupplier(SupplierObj);
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
