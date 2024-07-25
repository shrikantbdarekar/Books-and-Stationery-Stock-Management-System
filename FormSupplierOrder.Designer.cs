
namespace WinBookStationaryStock19
{
    partial class FormSupplierOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMain = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAddItem = new System.Windows.Forms.Button();
            this.textBoxItemQuantity = new System.Windows.Forms.TextBox();
            this.comboBoxItems = new System.Windows.Forms.ComboBox();
            this.textBoxOrderNo = new System.Windows.Forms.TextBox();
            this.labelOrderNo = new System.Windows.Forms.Label();
            this.dateTimePickerOrderDate = new System.Windows.Forms.DateTimePicker();
            this.labelTotal = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.dataGridViewItemList = new System.Windows.Forms.DataGridView();
            this.comboBoxSupplierName = new System.Windows.Forms.ComboBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelOrderDate = new System.Windows.Forms.Label();
            this.labelSupplierName = new System.Windows.Forms.Label();
            this.dgcOrderDetailID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcItemID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgcQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcPurchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgcDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItemList)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.Controls.Add(this.label4);
            this.panelMain.Controls.Add(this.buttonAddItem);
            this.panelMain.Controls.Add(this.textBoxItemQuantity);
            this.panelMain.Controls.Add(this.comboBoxItems);
            this.panelMain.Controls.Add(this.textBoxOrderNo);
            this.panelMain.Controls.Add(this.labelOrderNo);
            this.panelMain.Controls.Add(this.dateTimePickerOrderDate);
            this.panelMain.Controls.Add(this.labelTotal);
            this.panelMain.Controls.Add(this.textBoxTotal);
            this.panelMain.Controls.Add(this.dataGridViewItemList);
            this.panelMain.Controls.Add(this.comboBoxSupplierName);
            this.panelMain.Controls.Add(this.buttonCancel);
            this.panelMain.Controls.Add(this.buttonSave);
            this.panelMain.Controls.Add(this.labelOrderDate);
            this.panelMain.Controls.Add(this.labelSupplierName);
            this.panelMain.Location = new System.Drawing.Point(12, 12);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(680, 478);
            this.panelMain.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(536, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 18);
            this.label4.TabIndex = 31;
            this.label4.Text = "Qty";
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.Location = new System.Drawing.Point(572, 87);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(58, 27);
            this.buttonAddItem.TabIndex = 8;
            this.buttonAddItem.Text = "Add";
            this.buttonAddItem.UseVisualStyleBackColor = true;
            this.buttonAddItem.Click += new System.EventHandler(this.buttonAddItem_Click);
            // 
            // textBoxItemQuantity
            // 
            this.textBoxItemQuantity.Location = new System.Drawing.Point(451, 88);
            this.textBoxItemQuantity.Name = "textBoxItemQuantity";
            this.textBoxItemQuantity.Size = new System.Drawing.Size(83, 24);
            this.textBoxItemQuantity.TabIndex = 7;
            // 
            // comboBoxItems
            // 
            this.comboBoxItems.FormattingEnabled = true;
            this.comboBoxItems.Location = new System.Drawing.Point(53, 87);
            this.comboBoxItems.Name = "comboBoxItems";
            this.comboBoxItems.Size = new System.Drawing.Size(392, 26);
            this.comboBoxItems.TabIndex = 6;
            // 
            // textBoxOrderNo
            // 
            this.textBoxOrderNo.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxOrderNo.Location = new System.Drawing.Point(181, 50);
            this.textBoxOrderNo.Name = "textBoxOrderNo";
            this.textBoxOrderNo.ReadOnly = true;
            this.textBoxOrderNo.Size = new System.Drawing.Size(100, 24);
            this.textBoxOrderNo.TabIndex = 3;
            // 
            // labelOrderNo
            // 
            this.labelOrderNo.AutoSize = true;
            this.labelOrderNo.Location = new System.Drawing.Point(50, 53);
            this.labelOrderNo.Name = "labelOrderNo";
            this.labelOrderNo.Size = new System.Drawing.Size(74, 18);
            this.labelOrderNo.TabIndex = 2;
            this.labelOrderNo.Text = "Order No.";
            // 
            // dateTimePickerOrderDate
            // 
            this.dateTimePickerOrderDate.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerOrderDate.Location = new System.Drawing.Point(508, 50);
            this.dateTimePickerOrderDate.Name = "dateTimePickerOrderDate";
            this.dateTimePickerOrderDate.Size = new System.Drawing.Size(115, 24);
            this.dateTimePickerOrderDate.TabIndex = 5;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(522, 451);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(41, 18);
            this.labelTotal.TabIndex = 21;
            this.labelTotal.Text = "Total";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(569, 448);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(100, 24);
            this.textBoxTotal.TabIndex = 20;
            this.textBoxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dataGridViewItemList
            // 
            this.dataGridViewItemList.AllowUserToAddRows = false;
            this.dataGridViewItemList.AllowUserToDeleteRows = false;
            this.dataGridViewItemList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewItemList.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewItemList.ColumnHeadersHeight = 30;
            this.dataGridViewItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewItemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcOrderDetailID,
            this.dgcItemID,
            this.dgcQuantity,
            this.dgcPurchasePrice,
            this.dgcEdit,
            this.dgcDelete});
            this.dataGridViewItemList.Location = new System.Drawing.Point(4, 122);
            this.dataGridViewItemList.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewItemList.Name = "dataGridViewItemList";
            this.dataGridViewItemList.ReadOnly = true;
            this.dataGridViewItemList.Size = new System.Drawing.Size(672, 318);
            this.dataGridViewItemList.TabIndex = 9;
            this.dataGridViewItemList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewItemList_CellContentClick);
            // 
            // comboBoxSupplierName
            // 
            this.comboBoxSupplierName.FormattingEnabled = true;
            this.comboBoxSupplierName.Location = new System.Drawing.Point(181, 18);
            this.comboBoxSupplierName.Name = "comboBoxSupplierName";
            this.comboBoxSupplierName.Size = new System.Drawing.Size(442, 26);
            this.comboBoxSupplierName.TabIndex = 1;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(85, 447);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 27);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(4, 447);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 27);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelOrderDate
            // 
            this.labelOrderDate.AutoSize = true;
            this.labelOrderDate.Location = new System.Drawing.Point(377, 53);
            this.labelOrderDate.Name = "labelOrderDate";
            this.labelOrderDate.Size = new System.Drawing.Size(81, 18);
            this.labelOrderDate.TabIndex = 4;
            this.labelOrderDate.Text = "Order Date";
            // 
            // labelSupplierName
            // 
            this.labelSupplierName.AutoSize = true;
            this.labelSupplierName.Location = new System.Drawing.Point(50, 21);
            this.labelSupplierName.Name = "labelSupplierName";
            this.labelSupplierName.Size = new System.Drawing.Size(105, 18);
            this.labelSupplierName.TabIndex = 0;
            this.labelSupplierName.Text = "Supplier Name";
            // 
            // dgcOrderDetailID
            // 
            this.dgcOrderDetailID.DataPropertyName = "OrderDetailID";
            this.dgcOrderDetailID.HeaderText = "Order Detail Id";
            this.dgcOrderDetailID.Name = "dgcOrderDetailID";
            this.dgcOrderDetailID.ReadOnly = true;
            this.dgcOrderDetailID.Visible = false;
            // 
            // dgcItemID
            // 
            this.dgcItemID.DataPropertyName = "ItemID";
            this.dgcItemID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dgcItemID.HeaderText = "Item Name";
            this.dgcItemID.Name = "dgcItemID";
            this.dgcItemID.ReadOnly = true;
            this.dgcItemID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgcItemID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgcItemID.Width = 300;
            // 
            // dgcQuantity
            // 
            this.dgcQuantity.DataPropertyName = "Quantity";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgcQuantity.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgcQuantity.HeaderText = "Qty";
            this.dgcQuantity.Name = "dgcQuantity";
            this.dgcQuantity.ReadOnly = true;
            // 
            // dgcPurchasePrice
            // 
            this.dgcPurchasePrice.DataPropertyName = "PurchasePrice";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgcPurchasePrice.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgcPurchasePrice.HeaderText = "Price";
            this.dgcPurchasePrice.Name = "dgcPurchasePrice";
            this.dgcPurchasePrice.ReadOnly = true;
            // 
            // dgcEdit
            // 
            this.dgcEdit.HeaderText = "Edit";
            this.dgcEdit.Name = "dgcEdit";
            this.dgcEdit.ReadOnly = true;
            this.dgcEdit.Text = "Edit";
            this.dgcEdit.UseColumnTextForButtonValue = true;
            this.dgcEdit.Visible = false;
            // 
            // dgcDelete
            // 
            this.dgcDelete.HeaderText = "Delete";
            this.dgcDelete.Name = "dgcDelete";
            this.dgcDelete.ReadOnly = true;
            this.dgcDelete.Text = "Delete";
            this.dgcDelete.UseColumnTextForButtonValue = true;
            // 
            // FormSupplierOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(704, 502);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSupplierOrder";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supplier Order";
            this.Load += new System.EventHandler(this.FormSupplierOrder_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItemList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelOrderDate;
        private System.Windows.Forms.Label labelSupplierName;
        private System.Windows.Forms.ComboBox comboBoxSupplierName;
        private System.Windows.Forms.DataGridView dataGridViewItemList;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.DateTimePicker dateTimePickerOrderDate;
        private System.Windows.Forms.TextBox textBoxOrderNo;
        private System.Windows.Forms.Label labelOrderNo;
        private System.Windows.Forms.Button buttonAddItem;
        private System.Windows.Forms.TextBox textBoxItemQuantity;
        private System.Windows.Forms.ComboBox comboBoxItems;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcOrderDetailID;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgcItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcPurchasePrice;
        private System.Windows.Forms.DataGridViewButtonColumn dgcEdit;
        private System.Windows.Forms.DataGridViewButtonColumn dgcDelete;
    }
}