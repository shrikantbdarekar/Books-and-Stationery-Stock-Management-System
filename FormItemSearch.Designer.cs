
namespace WinBookStationaryStock19
{
    partial class FormItemSearch
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
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dgcItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcFullItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcReorder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcDPPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcMRPPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgcDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.AllowUserToAddRows = false;
            this.dataGridViewItems.AllowUserToDeleteRows = false;
            this.dataGridViewItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewItems.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewItems.ColumnHeadersHeight = 30;
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcItemId,
            this.dgcFullItemName,
            this.dgcItemName,
            this.dgcCategoryName,
            this.dgcQuantity,
            this.dgcReorder,
            this.dgcDPPrice,
            this.dgcMRPPrice,
            this.dgcEdit,
            this.dgcDelete});
            this.dataGridViewItems.Location = new System.Drawing.Point(18, 50);
            this.dataGridViewItems.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.ReadOnly = true;
            this.dataGridViewItems.Size = new System.Drawing.Size(1034, 498);
            this.dataGridViewItems.TabIndex = 0;
            this.dataGridViewItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewItems_CellContentClick);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(18, 16);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(125, 27);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "Add Item";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dgcItemId
            // 
            this.dgcItemId.DataPropertyName = "ItemID";
            this.dgcItemId.HeaderText = "Item Id";
            this.dgcItemId.Name = "dgcItemId";
            this.dgcItemId.Visible = false;
            // 
            // dgcFullItemName
            // 
            this.dgcFullItemName.DataPropertyName = "FullItemName";
            this.dgcFullItemName.HeaderText = "Item Full Name";
            this.dgcFullItemName.Name = "dgcFullItemName";
            this.dgcFullItemName.Width = 300;
            // 
            // dgcItemName
            // 
            this.dgcItemName.DataPropertyName = "ItemName";
            this.dgcItemName.HeaderText = "Item Name";
            this.dgcItemName.Name = "dgcItemName";
            this.dgcItemName.Visible = false;
            // 
            // dgcCategoryName
            // 
            this.dgcCategoryName.DataPropertyName = "CategoryName";
            this.dgcCategoryName.HeaderText = "Category";
            this.dgcCategoryName.Name = "dgcCategoryName";
            this.dgcCategoryName.Visible = false;
            // 
            // dgcQuantity
            // 
            this.dgcQuantity.DataPropertyName = "Quantity";
            this.dgcQuantity.HeaderText = "Qty";
            this.dgcQuantity.Name = "dgcQuantity";
            // 
            // dgcReorder
            // 
            this.dgcReorder.DataPropertyName = "ReorderPoint";
            this.dgcReorder.HeaderText = "ReOrder";
            this.dgcReorder.Name = "dgcReorder";
            // 
            // dgcDPPrice
            // 
            this.dgcDPPrice.DataPropertyName = "DPPrice";
            this.dgcDPPrice.HeaderText = "DP";
            this.dgcDPPrice.Name = "dgcDPPrice";
            // 
            // dgcMRPPrice
            // 
            this.dgcMRPPrice.DataPropertyName = "MRPPrice";
            this.dgcMRPPrice.HeaderText = "MRP";
            this.dgcMRPPrice.Name = "dgcMRPPrice";
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
            // FormItemSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1065, 561);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewItems);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormItemSearch";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item Search";
            this.Load += new System.EventHandler(this.FormUserSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewItems;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcFullItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcReorder;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDPPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcMRPPrice;
        private System.Windows.Forms.DataGridViewButtonColumn dgcEdit;
        private System.Windows.Forms.DataGridViewButtonColumn dgcDelete;
    }
}