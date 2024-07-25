
namespace WinBookStationaryStock19
{
    partial class FormSupplierSearch
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
            this.dataGridViewSupplier = new System.Windows.Forms.DataGridView();
            this.dgcSupplierID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcSupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcSupplierAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgcDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSupplier
            // 
            this.dataGridViewSupplier.AllowUserToAddRows = false;
            this.dataGridViewSupplier.AllowUserToDeleteRows = false;
            this.dataGridViewSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSupplier.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSupplier.ColumnHeadersHeight = 30;
            this.dataGridViewSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewSupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcSupplierID,
            this.dgcSupplierName,
            this.dgcSupplierAddress,
            this.Column4,
            this.dgcEdit,
            this.dgcDelete});
            this.dataGridViewSupplier.Location = new System.Drawing.Point(18, 50);
            this.dataGridViewSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewSupplier.Name = "dataGridViewSupplier";
            this.dataGridViewSupplier.ReadOnly = true;
            this.dataGridViewSupplier.Size = new System.Drawing.Size(881, 498);
            this.dataGridViewSupplier.TabIndex = 0;
            this.dataGridViewSupplier.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSupplier_CellContentClick);
            // 
            // dgcSupplierID
            // 
            this.dgcSupplierID.DataPropertyName = "SupplierID";
            this.dgcSupplierID.HeaderText = "Customer Id";
            this.dgcSupplierID.Name = "dgcSupplierID";
            this.dgcSupplierID.ReadOnly = true;
            this.dgcSupplierID.Visible = false;
            // 
            // dgcSupplierName
            // 
            this.dgcSupplierName.DataPropertyName = "SupplierName";
            this.dgcSupplierName.HeaderText = "Supplier Name";
            this.dgcSupplierName.Name = "dgcSupplierName";
            this.dgcSupplierName.ReadOnly = true;
            this.dgcSupplierName.Width = 200;
            // 
            // dgcSupplierAddress
            // 
            this.dgcSupplierAddress.DataPropertyName = "SupplierAddress";
            this.dgcSupplierAddress.HeaderText = "Address";
            this.dgcSupplierAddress.Name = "dgcSupplierAddress";
            this.dgcSupplierAddress.ReadOnly = true;
            this.dgcSupplierAddress.Width = 250;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ContactNo";
            this.Column4.HeaderText = "Contact No.";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
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
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(18, 16);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(125, 27);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "Add Supplier";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // FormSupplierSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(912, 561);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewSupplier);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSupplierSearch";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supplier Search";
            this.Load += new System.EventHandler(this.FormUserSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupplier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSupplier;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcSupplierID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcSupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcSupplierAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn dgcEdit;
        private System.Windows.Forms.DataGridViewButtonColumn dgcDelete;
    }
}