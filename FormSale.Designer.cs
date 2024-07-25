
namespace WinBookStationaryStock19
{
    partial class FormSale
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMain = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBoxBillNo = new System.Windows.Forms.TextBox();
            this.labelBillNo = new System.Windows.Forms.Label();
            this.dateTimePickerSaleDate = new System.Windows.Forms.DateTimePicker();
            this.labelTotal = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.comboBoxItems = new System.Windows.Forms.ComboBox();
            this.dataGridViewItemList = new System.Windows.Forms.DataGridView();
            this.comboBoxCustomerID = new System.Windows.Forms.ComboBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelSaleDate = new System.Windows.Forms.Label();
            this.labelCustomerID = new System.Windows.Forms.Label();
            this.dgcSaleDetailID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcItemID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgcQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panelMain.Controls.Add(this.buttonAdd);
            this.panelMain.Controls.Add(this.label5);
            this.panelMain.Controls.Add(this.label4);
            this.panelMain.Controls.Add(this.textBox4);
            this.panelMain.Controls.Add(this.textBoxBillNo);
            this.panelMain.Controls.Add(this.labelBillNo);
            this.panelMain.Controls.Add(this.dateTimePickerSaleDate);
            this.panelMain.Controls.Add(this.labelTotal);
            this.panelMain.Controls.Add(this.textBoxTotal);
            this.panelMain.Controls.Add(this.textBoxQuantity);
            this.panelMain.Controls.Add(this.comboBoxItems);
            this.panelMain.Controls.Add(this.dataGridViewItemList);
            this.panelMain.Controls.Add(this.comboBoxCustomerID);
            this.panelMain.Controls.Add(this.buttonCancel);
            this.panelMain.Controls.Add(this.buttonSave);
            this.panelMain.Controls.Add(this.labelSaleDate);
            this.panelMain.Controls.Add(this.labelCustomerID);
            this.panelMain.Location = new System.Drawing.Point(12, 12);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(680, 478);
            this.panelMain.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(569, 88);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(58, 27);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DarkGray;
            this.label5.Location = new System.Drawing.Point(380, 448);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 18);
            this.label5.TabIndex = 35;
            this.label5.Text = "Price";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(519, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 18);
            this.label4.TabIndex = 34;
            this.label4.Text = "Qty";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(374, 446);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(52, 24);
            this.textBox4.TabIndex = 25;
            this.textBox4.Visible = false;
            // 
            // textBoxBillNo
            // 
            this.textBoxBillNo.BackColor = System.Drawing.Color.White;
            this.textBoxBillNo.Location = new System.Drawing.Point(185, 50);
            this.textBoxBillNo.Name = "textBoxBillNo";
            this.textBoxBillNo.ReadOnly = true;
            this.textBoxBillNo.Size = new System.Drawing.Size(100, 24);
            this.textBoxBillNo.TabIndex = 3;
            // 
            // labelBillNo
            // 
            this.labelBillNo.AutoSize = true;
            this.labelBillNo.Location = new System.Drawing.Point(54, 53);
            this.labelBillNo.Name = "labelBillNo";
            this.labelBillNo.Size = new System.Drawing.Size(55, 18);
            this.labelBillNo.TabIndex = 2;
            this.labelBillNo.Text = "Bill No.";
            // 
            // dateTimePickerSaleDate
            // 
            this.dateTimePickerSaleDate.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerSaleDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerSaleDate.Location = new System.Drawing.Point(512, 50);
            this.dateTimePickerSaleDate.Name = "dateTimePickerSaleDate";
            this.dateTimePickerSaleDate.Size = new System.Drawing.Size(115, 24);
            this.dateTimePickerSaleDate.TabIndex = 5;
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
            this.textBoxTotal.Size = new System.Drawing.Size(100, 24);
            this.textBoxTotal.TabIndex = 20;
            this.textBoxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(433, 90);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(83, 24);
            this.textBoxQuantity.TabIndex = 7;
            this.textBoxQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // comboBoxItems
            // 
            this.comboBoxItems.FormattingEnabled = true;
            this.comboBoxItems.Location = new System.Drawing.Point(57, 89);
            this.comboBoxItems.Name = "comboBoxItems";
            this.comboBoxItems.Size = new System.Drawing.Size(370, 26);
            this.comboBoxItems.TabIndex = 6;
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
            this.dgcSaleDetailID,
            this.dgcItemID,
            this.dgcQuantity,
            this.dgcPrice,
            this.dgcEdit,
            this.dgcDelete});
            this.dataGridViewItemList.Location = new System.Drawing.Point(4, 122);
            this.dataGridViewItemList.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewItemList.Name = "dataGridViewItemList";
            this.dataGridViewItemList.Size = new System.Drawing.Size(672, 318);
            this.dataGridViewItemList.TabIndex = 9;
            this.dataGridViewItemList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewItemList_CellContentClick);
            // 
            // comboBoxCustomerID
            // 
            this.comboBoxCustomerID.FormattingEnabled = true;
            this.comboBoxCustomerID.Location = new System.Drawing.Point(185, 18);
            this.comboBoxCustomerID.Name = "comboBoxCustomerID";
            this.comboBoxCustomerID.Size = new System.Drawing.Size(442, 26);
            this.comboBoxCustomerID.TabIndex = 1;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(85, 447);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 27);
            this.buttonCancel.TabIndex = 12;
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
            // labelSaleDate
            // 
            this.labelSaleDate.AutoSize = true;
            this.labelSaleDate.Location = new System.Drawing.Point(381, 53);
            this.labelSaleDate.Name = "labelSaleDate";
            this.labelSaleDate.Size = new System.Drawing.Size(62, 18);
            this.labelSaleDate.TabIndex = 4;
            this.labelSaleDate.Text = "Bill Date";
            // 
            // labelCustomerID
            // 
            this.labelCustomerID.AutoSize = true;
            this.labelCustomerID.Location = new System.Drawing.Point(54, 21);
            this.labelCustomerID.Name = "labelCustomerID";
            this.labelCustomerID.Size = new System.Drawing.Size(118, 18);
            this.labelCustomerID.TabIndex = 0;
            this.labelCustomerID.Text = "Customer Name";
            // 
            // dgcSaleDetailID
            // 
            this.dgcSaleDetailID.DataPropertyName = "SaleDetailID";
            this.dgcSaleDetailID.HeaderText = "Sale Detail Id";
            this.dgcSaleDetailID.Name = "dgcSaleDetailID";
            this.dgcSaleDetailID.Visible = false;
            // 
            // dgcItemID
            // 
            this.dgcItemID.DataPropertyName = "ItemID";
            this.dgcItemID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dgcItemID.HeaderText = "Item Name";
            this.dgcItemID.Name = "dgcItemID";
            this.dgcItemID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgcItemID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgcItemID.Width = 250;
            // 
            // dgcQuantity
            // 
            this.dgcQuantity.DataPropertyName = "Quantity";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgcQuantity.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgcQuantity.HeaderText = "Qty";
            this.dgcQuantity.Name = "dgcQuantity";
            // 
            // dgcPrice
            // 
            this.dgcPrice.DataPropertyName = "Price";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgcPrice.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgcPrice.HeaderText = "Price";
            this.dgcPrice.Name = "dgcPrice";
            // 
            // dgcEdit
            // 
            this.dgcEdit.HeaderText = "Edit";
            this.dgcEdit.Name = "dgcEdit";
            this.dgcEdit.Text = "Edit";
            this.dgcEdit.UseColumnTextForButtonValue = true;
            this.dgcEdit.Visible = false;
            // 
            // dgcDelete
            // 
            this.dgcDelete.HeaderText = "Delete";
            this.dgcDelete.Name = "dgcDelete";
            this.dgcDelete.Text = "Delete";
            this.dgcDelete.UseColumnTextForButtonValue = true;
            // 
            // FormSale
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
            this.Name = "FormSale";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sale Details";
            this.Load += new System.EventHandler(this.FormSale_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItemList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelSaleDate;
        private System.Windows.Forms.Label labelCustomerID;
        private System.Windows.Forms.ComboBox comboBoxCustomerID;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.ComboBox comboBoxItems;
        private System.Windows.Forms.DataGridView dataGridViewItemList;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.DateTimePicker dateTimePickerSaleDate;
        private System.Windows.Forms.TextBox textBoxBillNo;
        private System.Windows.Forms.Label labelBillNo;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcSaleDetailID;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgcItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcPrice;
        private System.Windows.Forms.DataGridViewButtonColumn dgcEdit;
        private System.Windows.Forms.DataGridViewButtonColumn dgcDelete;
    }
}