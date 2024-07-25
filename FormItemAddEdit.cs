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
    public partial class FormItemAddEdit : Form
    {
        private int ItemID;
        private Item ItemObj;
        private DALItems DALItemObj;
        private DALCategories DALCAtegoryObj;
        public FormItemAddEdit(int ItemID)
        {
            InitializeComponent();

            this.ItemID = ItemID;

            ItemObj = new Item();
            DALItemObj = new DALItems(MyConnectioString.Value);
            DALCAtegoryObj = new DALCategories(MyConnectioString.Value);
        }

        private void FormItemAddEdit_Load(object sender, EventArgs e)
        {
            comboBoxCategory.DataSource = DALCAtegoryObj.GetCategoryList();
            comboBoxCategory.DisplayMember = "CategoryName";
            comboBoxCategory.ValueMember = "CategoryId";

            if (ItemID != 0)
            {
                ItemObj = DALItemObj.GetItemById(ItemID);

                textBoxItemName.Text = ItemObj.ItemName;
                comboBoxCategory.SelectedValue = ItemObj.CategoryID;
                textBoxQuantity.Text = ItemObj.Quantity.ToString();
                textBoxReorderPoint.Text = ItemObj.ReorderPoint.ToString();
                textBoxDPPrice.Text = ItemObj.DPPrice.ToString();
                textBoxMRPPrice.Text = ItemObj.MRPPrice.ToString();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                ItemObj.ItemName = textBoxItemName.Text;
                ItemObj.CategoryID = Convert.ToInt32(comboBoxCategory.SelectedValue.ToString());
                ItemObj.Quantity = Convert.ToInt32(textBoxQuantity.Text);
                ItemObj.ReorderPoint = Convert.ToInt32(textBoxReorderPoint.Text);
                ItemObj.DPPrice = Convert.ToDecimal(textBoxDPPrice.Text);
                ItemObj.MRPPrice = Convert.ToDecimal(textBoxMRPPrice.Text);

                if (ItemID == 0)
                {
                    DALItemObj.AddItem(ItemObj);
                }
                else
                {
                    DALItemObj.UpdateItem(ItemObj);
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
