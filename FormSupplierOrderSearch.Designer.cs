
namespace WinBookStationaryStock19
{
    partial class FormSupplierOrderSearch
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
            this.dataGridViewSupplierOrders = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dgcOrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcSupplierId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgcOrderNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcOrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgcDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupplierOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSupplierOrders
            // 
            this.dataGridViewSupplierOrders.AllowUserToAddRows = false;
            this.dataGridViewSupplierOrders.AllowUserToDeleteRows = false;
            this.dataGridViewSupplierOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSupplierOrders.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSupplierOrders.ColumnHeadersHeight = 30;
            this.dataGridViewSupplierOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewSupplierOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcOrderID,
            this.dgcSupplierId,
            this.dgcOrderNo,
            this.dgcOrderDate,
            this.Column7,
            this.dgcEdit,
            this.dgcDelete});
            this.dataGridViewSupplierOrders.Location = new System.Drawing.Point(18, 50);
            this.dataGridViewSupplierOrders.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewSupplierOrders.Name = "dataGridViewSupplierOrders";
            this.dataGridViewSupplierOrders.ReadOnly = true;
            this.dataGridViewSupplierOrders.Size = new System.Drawing.Size(881, 498);
            this.dataGridViewSupplierOrders.TabIndex = 0;
            this.dataGridViewSupplierOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSupplierOrders_CellContentClick);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(18, 16);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(125, 27);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "Add Order";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dgcOrderID
            // 
            this.dgcOrderID.DataPropertyName = "OrderID";
            this.dgcOrderID.HeaderText = "Order Id";
            this.dgcOrderID.Name = "dgcOrderID";
            this.dgcOrderID.ReadOnly = true;
            this.dgcOrderID.Visible = false;
            // 
            // dgcSupplierId
            // 
            this.dgcSupplierId.DataPropertyName = "SupplierId";
            this.dgcSupplierId.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dgcSupplierId.HeaderText = "Supplier Name";
            this.dgcSupplierId.Name = "dgcSupplierId";
            this.dgcSupplierId.ReadOnly = true;
            this.dgcSupplierId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgcSupplierId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgcSupplierId.Width = 300;
            // 
            // dgcOrderNo
            // 
            this.dgcOrderNo.DataPropertyName = "OrderNo";
            this.dgcOrderNo.HeaderText = "Order No.";
            this.dgcOrderNo.Name = "dgcOrderNo";
            this.dgcOrderNo.ReadOnly = true;
            // 
            // dgcOrderDate
            // 
            this.dgcOrderDate.DataPropertyName = "OrderDate";
            this.dgcOrderDate.HeaderText = "Date";
            this.dgcOrderDate.Name = "dgcOrderDate";
            this.dgcOrderDate.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Amount";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            // 
            // dgcEdit
            // 
            this.dgcEdit.HeaderText = "Edit";
            this.dgcEdit.Name = "dgcEdit";
            this.dgcEdit.ReadOnly = true;
            this.dgcEdit.Text = "Edit";
            this.dgcEdit.UseColumnTextForButtonValue = true;
            // 
            // dgcDelete
            // 
            this.dgcDelete.HeaderText = "Delete";
            this.dgcDelete.Name = "dgcDelete";
            this.dgcDelete.ReadOnly = true;
            this.dgcDelete.Text = "Delete";
            this.dgcDelete.UseColumnTextForButtonValue = true;
            // 
            // FormSupplierOrderSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(912, 561);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewSupplierOrders);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSupplierOrderSearch";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supplier Order Search";
            this.Load += new System.EventHandler(this.FormUserSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupplierOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSupplierOrders;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcOrderID;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgcSupplierId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcOrderNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcOrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewButtonColumn dgcEdit;
        private System.Windows.Forms.DataGridViewButtonColumn dgcDelete;
    }
}