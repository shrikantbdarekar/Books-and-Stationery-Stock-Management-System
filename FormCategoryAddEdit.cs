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
    public partial class FormCategoryAddEdit : Form
    {
        private int CategoryId;
        private Category CategoryObj;
        private DALCategories DALCategoriyObj;
        public FormCategoryAddEdit(int CategoryId)
        {
            InitializeComponent();

            this.CategoryId = CategoryId;

            CategoryObj = new Category();
            DALCategoriyObj = new DALCategories(MyConnectioString.Value);
        }

        private void FormCategoryAddEdit_Load(object sender, EventArgs e)
        {
            if (CategoryId != 0)
            {
                CategoryObj = DALCategoriyObj.GetCategoryById(CategoryId);

                textBoxCategoryName.Text = CategoryObj.CategoryName;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                CategoryObj.CategoryName = textBoxCategoryName.Text;

                if (CategoryId == 0)
                {
                    DALCategoriyObj.AddCategory(CategoryObj);
                }
                else
                {
                    DALCategoriyObj.UpdateCategory(CategoryObj);
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
