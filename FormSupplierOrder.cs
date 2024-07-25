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
    public partial class FormSupplierOrder : Form
    {
        private int OrderID;
        private SupplierOrder SupplierOrderObj;
        private DALSupplierOrders DALSupplierOrderObj;
        private SupplierOrderDetail SupplierOrderDetailObj;
        private DALSupplierOrderDetails DALSupplierOrderDetailObj;
        private List<SupplierOrderDetail> MyItemList;

        private Item ItemObj;
        private DALItems DALItemObj;
        private DALSuppliers DALSupplierObj;
        
        public FormSupplierOrder(int OrderID)
        {
            InitializeComponent();

            this.OrderID = OrderID;

            SupplierOrderObj = new SupplierOrder();
            DALSupplierOrderObj = new DALSupplierOrders(MyConnectioString.Value);
            SupplierOrderDetailObj = new SupplierOrderDetail();
            DALSupplierOrderDetailObj = new DALSupplierOrderDetails(MyConnectioString.Value);

            ItemObj = new Item();
            DALItemObj = new DALItems(MyConnectioString.Value);
            DALSupplierObj = new DALSuppliers(MyConnectioString.Value);

            MyItemList = new List<SupplierOrderDetail>();

            dataGridViewItemList.AutoGenerateColumns = false;
        }

        private void FormSupplierOrder_Load(object sender, EventArgs e)
        {
            comboBoxSupplierName.DataSource = DALSupplierObj.GetSupplierList();
            comboBoxSupplierName.DisplayMember = "SupplierName";
            comboBoxSupplierName.ValueMember = "SupplierId";

            comboBoxItems.DataSource = DALItemObj.GetItemList();
            comboBoxItems.DisplayMember = "FullItemName";
            comboBoxItems.ValueMember = "ItemId";

            dgcItemID.DataSource = DALItemObj.GetItemList();
            dgcItemID.DisplayMember = "FullItemName";
            dgcItemID.ValueMember = "ItemId";

            if (OrderID != 0)
            {
                SupplierOrderObj = DALSupplierOrderObj.GetSupplierOrderById(OrderID);

                comboBoxSupplierName.SelectedValue = SupplierOrderObj.SupplierID;
                textBoxOrderNo.Text = SupplierOrderObj.OrderNo.ToString();
                dateTimePickerOrderDate.Value = SupplierOrderObj.OrderDate;
                textBoxTotal.Text = SupplierOrderObj.TotalAmount.ToString();

                LoadOrderItems(SupplierOrderObj.OrderID);
            }
            else
            {
                textBoxOrderNo.Text = DALSupplierOrderObj.GetOrderNo().ToString();
            }
        }

        private void LoadOrderItems(int OrderId)
        {
            dataGridViewItemList.DataSource = null;
            dataGridViewItemList.DataSource = DALSupplierOrderDetailObj.GetSupplierOrderDetailsByOrderId(OrderId);
        }

        private decimal GetGridTotal()
        {
            decimal OrderTotal = 0;
            for (int i = 0; i < dataGridViewItemList.RowCount; i++)
            {
                OrderTotal += Convert.ToDecimal(dataGridViewItemList.Rows[i].Cells[dgcPurchasePrice.Name].Value) *
                    Convert.ToDecimal(dataGridViewItemList.Rows[i].Cells[dgcQuantity.Name].Value);
            }
            return OrderTotal;
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                SupplierOrderObj.SupplierID = (int)comboBoxSupplierName.SelectedValue;
                SupplierOrderObj.OrderNo = Convert.ToInt32(textBoxOrderNo.Text);
                SupplierOrderObj.OrderDate = dateTimePickerOrderDate.Value;
                SupplierOrderObj.TotalAmount = GetGridTotal();

                if (OrderID == 0)
                {
                   int insertedOrderID = DALSupplierOrderObj.AddSupplierOrder(SupplierOrderObj);

                    foreach (SupplierOrderDetail orderDetailObj in MyItemList)
                    {
                        SupplierOrderDetailObj = new SupplierOrderDetail();
                        SupplierOrderDetailObj.OrderID = insertedOrderID;
                        SupplierOrderDetailObj.ItemID = orderDetailObj.ItemID;
                        SupplierOrderDetailObj.Quantity = orderDetailObj.Quantity;
                        SupplierOrderDetailObj.PurchasePrice = orderDetailObj.PurchasePrice;

                        DALSupplierOrderDetailObj.AddSupplierOrderDetail(SupplierOrderDetailObj);
                    }
                }
                else
                {
                    DALSupplierOrderObj.UpdateSupplierOrder(SupplierOrderObj);
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

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            try
            {
                SupplierOrderDetailObj = new SupplierOrderDetail();
                SupplierOrderDetailObj.OrderID = SupplierOrderObj.OrderID;
                SupplierOrderDetailObj.ItemID = (int)comboBoxItems.SelectedValue;
                Item SelectedItem = (Item)comboBoxItems.SelectedItem;
                SupplierOrderDetailObj.PurchasePrice = SelectedItem.DPPrice;
                SupplierOrderDetailObj.Quantity = Convert.ToInt32(textBoxItemQuantity.Text);
             
                if (SupplierOrderObj.OrderID == 0)
                {
                    dataGridViewItemList.DataSource = null;
                    MyItemList.Add(SupplierOrderDetailObj);
                    dataGridViewItemList.DataSource = MyItemList;

                    // Another way to set dayasource
                    // BindingList<SupplierOrderDetail> MyItemList = new BindingList<SupplierOrderDetail>();
                    // MyItemList.Add(SupplierOrderDetailObj);
                    // dataGridViewItemList.DataSource = MyItemList;
                }
                else
                {
                    DALSupplierOrderDetailObj.AddSupplierOrderDetail(SupplierOrderDetailObj);
                    LoadOrderItems(SupplierOrderObj.OrderID);
                }

                textBoxItemQuantity.Text = "";
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
                int OrderDetailID = Convert.ToInt32(dataGridViewItemList.CurrentRow.Cells[dgcOrderDetailID.Name].Value);

                if (e.ColumnIndex == dgcDelete.Index)
                {
                    if (MessageBox.Show("Do you want to Delete this record ?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (SupplierOrderObj.OrderID == 0)
                        {
                            // Remove from list
                            MyItemList.RemoveAt(e.RowIndex);
                            dataGridViewItemList.DataSource = null;
                            dataGridViewItemList.DataSource = MyItemList;
                        }
                        else
                        {
                            // Delete record from database.
                            DALSupplierOrderDetailObj.DeleteSupplierOrderDetail(OrderDetailID);
                            LoadOrderItems(SupplierOrderObj.OrderID);
                        }
                    }
                }
            }
        }
    }
}
