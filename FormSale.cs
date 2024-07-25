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
    public partial class FormSale : Form
    {
        private int SaleID;
        private Sale SaleObj;
        private DALSales DALSaleObj;
        private SaleDetail SaleDetailObj;
        private DALSaleDetails DALSaleDetailObj;
        private List<SaleDetail> MyItemList;

        private Item ItemObj;
        private DALItems DALItemObj;
        private DALCustomers DALCustomerObj;

        public FormSale(int SaleID)
        {
            InitializeComponent();

            this.SaleID = SaleID;

            SaleObj = new Sale();
            DALSaleObj = new DALSales(MyConnectioString.Value);
            SaleDetailObj = new SaleDetail();
            DALSaleDetailObj = new DALSaleDetails(MyConnectioString.Value);

            ItemObj = new Item();
            DALItemObj = new DALItems(MyConnectioString.Value);
            DALCustomerObj = new DALCustomers(MyConnectioString.Value);

            MyItemList = new List<SaleDetail>();

            dataGridViewItemList.AutoGenerateColumns = false;
        }

        private void FormSale_Load(object sender, EventArgs e)
        {
            comboBoxCustomerID.DataSource = DALCustomerObj.GetCustomerList();
            comboBoxCustomerID.DisplayMember = "CustomerName";
            comboBoxCustomerID.ValueMember = "CustomerId";

            comboBoxItems.DataSource = DALItemObj.GetItemList();
            comboBoxItems.DisplayMember = "FullItemName";
            comboBoxItems.ValueMember = "ItemId";

            dgcItemID.DataSource = DALItemObj.GetItemList();
            dgcItemID.DisplayMember = "FullItemName";
            dgcItemID.ValueMember = "ItemId";

            if (SaleID != 0)
            {
                SaleObj = DALSaleObj.GetSaleById(SaleID);

                comboBoxCustomerID.SelectedValue = SaleObj.CustomerID;
                textBoxBillNo.Text = SaleObj.BillNo.ToString();
                dateTimePickerSaleDate.Value = SaleObj.SaleDate;

                LoadOrderItems(SaleObj.SaleID);
            }
            else
            {
                textBoxBillNo.Text = DALSaleObj.GetBillNo().ToString();
            }
        }

        private void LoadOrderItems(int SaleId)
        {
            dataGridViewItemList.DataSource = null;
            dataGridViewItemList.DataSource = DALSaleDetailObj.GetSaleDetailsBySaleId(SaleId);
        }

        private decimal GetGridTotal()
        {
            decimal BillTotal = 0;
            for (int i = 0; i < dataGridViewItemList.RowCount; i++)
            {
                BillTotal += Convert.ToDecimal(dataGridViewItemList.Rows[i].Cells[dgcPrice.Name].Value) *
                    Convert.ToDecimal(dataGridViewItemList.Rows[i].Cells[dgcQuantity.Name].Value);
            }
            return BillTotal;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaleObj.BillNo = Convert.ToInt32(textBoxBillNo.Text);
                SaleObj.CustomerID = (int)comboBoxCustomerID.SelectedValue;
                SaleObj.BillNo = Convert.ToInt32(textBoxBillNo.Text);
                SaleObj.SaleDate = dateTimePickerSaleDate.Value;
                SaleObj.TotalAmount = GetGridTotal();

                if (SaleID == 0)
                {
                    int insertedOrderID = DALSaleObj.AddSale(SaleObj);

                    foreach (SaleDetail saleDetailObj in MyItemList)
                    {
                        SaleDetailObj = new SaleDetail();
                        SaleDetailObj.SaleID = insertedOrderID;
                        SaleDetailObj.ItemID = saleDetailObj.ItemID;
                        SaleDetailObj.Quantity = saleDetailObj.Quantity;
                        SaleDetailObj.Price = saleDetailObj.Price;
                        DALSaleDetailObj.AddSaleDetail(SaleDetailObj);
                    }
                }
                else
                {
                    DALSaleObj.UpdateSale(SaleObj);
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                
                SaleDetailObj = new SaleDetail();
                SaleDetailObj.SaleID = SaleObj.SaleID;
                SaleDetailObj.ItemID = (int)comboBoxItems.SelectedValue;
                Item SelectedItem = (Item)comboBoxItems.SelectedItem;
                SaleDetailObj.Price = SelectedItem.MRPPrice;
                SaleDetailObj.Quantity = Convert.ToInt32(textBoxQuantity.Text);

                if (SaleObj.SaleID == 0)
                {
                    dataGridViewItemList.DataSource = null;
                    MyItemList.Add(SaleDetailObj);
                    dataGridViewItemList.DataSource = MyItemList;

                    // Another way to set dayasource
                    // BindingList<SupplierOrderDetail> MyItemList = new BindingList<SupplierOrderDetail>();
                    // MyItemList.Add(SupplierOrderDetailObj);
                    // dataGridViewItemList.DataSource = MyItemList;
                }
                else
                {
                    DALSaleDetailObj.AddSaleDetail(SaleDetailObj);
                    LoadOrderItems(SaleObj.SaleID);
                }

                textBoxQuantity.Text = "";
                textBoxTotal.Text = GetGridTotal().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }

        private void dataGridViewItemList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgcDelete.Index)
            {
                int SaleDetailID = Convert.ToInt32(dataGridViewItemList.CurrentRow.Cells[dgcSaleDetailID.Name].Value);

                if (e.ColumnIndex == dgcDelete.Index)
                {
                    if (MessageBox.Show("Do you want to Delete this record ?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (SaleObj.SaleID == 0)
                        {
                            // Remove from list
                            MyItemList.RemoveAt(e.RowIndex);
                            dataGridViewItemList.DataSource = null;
                            dataGridViewItemList.DataSource = MyItemList;
                        }
                        else
                        {
                            // Delete record from database.
                            DALSaleDetailObj.DeleteSaleDetail(SaleDetailID);
                            LoadOrderItems(SaleID);
                        }
                    }
                }

                
            }
        }
    }
}
