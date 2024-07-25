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
    public partial class FormShopDetails : Form
    {
        private int ShopId;
        private ShopDetail ShopDetailObj;
        private DALShopDetails DALShopDetailsObj;
        public FormShopDetails()
        {
            InitializeComponent();

            ShopId = Properties.Settings.Default.ShopId;
            ShopDetailObj = new ShopDetail();
            DALShopDetailsObj = new DALShopDetails(MyConnectioString.Value);
        }

        private void FormShopDetails_Load(object sender, EventArgs e)
        {
            if (ShopId != 0)
            {
                ShopDetailObj = DALShopDetailsObj.GetShopDetailById(ShopId);

                textBoxShopName.Text = ShopDetailObj.ShopName;
                textBoxShopAddress.Text = ShopDetailObj.ShopAddress;
                textBoxEmail.Text = ShopDetailObj.Email;
                textBoxWebsite.Text = ShopDetailObj.Website;
                textBoxMobileNo.Text = ShopDetailObj.MobileNo;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                ShopDetailObj.ShopName = textBoxShopName.Text;
                ShopDetailObj.ShopAddress = textBoxShopAddress.Text;
                ShopDetailObj.Email = textBoxEmail.Text;
                ShopDetailObj.Website = textBoxWebsite.Text;
                ShopDetailObj.MobileNo= textBoxMobileNo.Text;

                if (ShopId != 0)
                {
                    DALShopDetailsObj.UpdateShopDetail(ShopDetailObj);
                }

                MessageBox.Show("Data updated succedssfully !!!");
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
