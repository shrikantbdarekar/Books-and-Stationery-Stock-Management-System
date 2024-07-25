
namespace WinBookStationaryStock19
{
    partial class FormSaleSearch
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
            this.dataGridViewSales = new System.Windows.Forms.DataGridView();
            this.dgcSaleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcCustomerID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgcBillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcSaleDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgcDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonPrintBill = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSales
            // 
            this.dataGridViewSales.AllowUserToAddRows = false;
            this.dataGridViewSales.AllowUserToDeleteRows = false;
            this.dataGridViewSales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSales.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSales.ColumnHeadersHeight = 30;
            this.dataGridViewSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcSaleID,
            this.dgcCustomerID,
            this.dgcBillNo,
            this.dgcSaleDate,
            this.dgcTotalAmount,
            this.dgcEdit,
            this.dgcDelete});
            this.dataGridViewSales.Location = new System.Drawing.Point(18, 50);
            this.dataGridViewSales.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewSales.Name = "dataGridViewSales";
            this.dataGridViewSales.Size = new System.Drawing.Size(881, 498);
            this.dataGridViewSales.TabIndex = 0;
            this.dataGridViewSales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSales_CellContentClick);
            // 
            // dgcSaleID
            // 
            this.dgcSaleID.DataPropertyName = "SaleID";
            this.dgcSaleID.HeaderText = "Sale Id";
            this.dgcSaleID.Name = "dgcSaleID";
            this.dgcSaleID.Visible = false;
            // 
            // dgcCustomerID
            // 
            this.dgcCustomerID.DataPropertyName = "CustomerID";
            this.dgcCustomerID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dgcCustomerID.HeaderText = "Customer Name";
            this.dgcCustomerID.Name = "dgcCustomerID";
            this.dgcCustomerID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgcCustomerID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgcCustomerID.Width = 300;
            // 
            // dgcBillNo
            // 
            this.dgcBillNo.DataPropertyName = "BillNo";
            this.dgcBillNo.HeaderText = "Bill No.";
            this.dgcBillNo.Name = "dgcBillNo";
            // 
            // dgcSaleDate
            // 
            this.dgcSaleDate.DataPropertyName = "SaleDate";
            this.dgcSaleDate.HeaderText = "Date";
            this.dgcSaleDate.Name = "dgcSaleDate";
            // 
            // dgcTotalAmount
            // 
            this.dgcTotalAmount.DataPropertyName = "TotalAmount";
            this.dgcTotalAmount.HeaderText = "Amount";
            this.dgcTotalAmount.Name = "dgcTotalAmount";
            // 
            // dgcEdit
            // 
            this.dgcEdit.HeaderText = "Edit";
            this.dgcEdit.Name = "dgcEdit";
            this.dgcEdit.Text = "Edit";
            this.dgcEdit.UseColumnTextForButtonValue = true;
            // 
            // dgcDelete
            // 
            this.dgcDelete.HeaderText = "Delete";
            this.dgcDelete.Name = "dgcDelete";
            this.dgcDelete.Text = "Delete";
            this.dgcDelete.UseColumnTextForButtonValue = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(18, 16);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(125, 27);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "Add Sale";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonPrintBill
            // 
            this.buttonPrintBill.Location = new System.Drawing.Point(774, 16);
            this.buttonPrintBill.Name = "buttonPrintBill";
            this.buttonPrintBill.Size = new System.Drawing.Size(125, 27);
            this.buttonPrintBill.TabIndex = 13;
            this.buttonPrintBill.Text = "Print Bill";
            this.buttonPrintBill.UseVisualStyleBackColor = true;
            this.buttonPrintBill.Click += new System.EventHandler(this.buttonPrintBill_Click);
            // 
            // FormSaleSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(912, 561);
            this.Controls.Add(this.buttonPrintBill);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewSales);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSaleSearch";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sale Search";
            this.Load += new System.EventHandler(this.FormUserSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSales;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonPrintBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcSaleID;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgcCustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcBillNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcSaleDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcTotalAmount;
        private System.Windows.Forms.DataGridViewButtonColumn dgcEdit;
        private System.Windows.Forms.DataGridViewButtonColumn dgcDelete;
    }
}