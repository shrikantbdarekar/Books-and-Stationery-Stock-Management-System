
namespace WinBookStationaryStock19
{
    partial class FormCustomerSearch
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
            this.dataGridViewCustomers = new System.Windows.Forms.DataGridView();
            this.dgcCustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcContactNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgcDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCustomers
            // 
            this.dataGridViewCustomers.AllowUserToAddRows = false;
            this.dataGridViewCustomers.AllowUserToDeleteRows = false;
            this.dataGridViewCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCustomers.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCustomers.ColumnHeadersHeight = 30;
            this.dataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcCustomerId,
            this.dgcCustomerName,
            this.dgcAddress,
            this.dgcContactNo,
            this.dgcEdit,
            this.dgcDelete});
            this.dataGridViewCustomers.Location = new System.Drawing.Point(18, 50);
            this.dataGridViewCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewCustomers.Name = "dataGridViewCustomers";
            this.dataGridViewCustomers.ReadOnly = true;
            this.dataGridViewCustomers.Size = new System.Drawing.Size(881, 498);
            this.dataGridViewCustomers.TabIndex = 0;
            this.dataGridViewCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCustomers_CellContentClick);
            // 
            // dgcCustomerId
            // 
            this.dgcCustomerId.DataPropertyName = "CustomerID";
            this.dgcCustomerId.HeaderText = "Customer Id";
            this.dgcCustomerId.Name = "dgcCustomerId";
            this.dgcCustomerId.ReadOnly = true;
            this.dgcCustomerId.Visible = false;
            // 
            // dgcCustomerName
            // 
            this.dgcCustomerName.DataPropertyName = "CustomerName";
            this.dgcCustomerName.HeaderText = "Customer Name";
            this.dgcCustomerName.Name = "dgcCustomerName";
            this.dgcCustomerName.ReadOnly = true;
            this.dgcCustomerName.Width = 200;
            // 
            // dgcAddress
            // 
            this.dgcAddress.DataPropertyName = "CustomerAddress";
            this.dgcAddress.HeaderText = "Address";
            this.dgcAddress.Name = "dgcAddress";
            this.dgcAddress.ReadOnly = true;
            this.dgcAddress.Width = 250;
            // 
            // dgcContactNo
            // 
            this.dgcContactNo.DataPropertyName = "ContactNo";
            this.dgcContactNo.HeaderText = "Contact No.";
            this.dgcContactNo.Name = "dgcContactNo";
            this.dgcContactNo.ReadOnly = true;
            this.dgcContactNo.Width = 150;
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
            this.buttonAdd.Text = "Add Customer";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // FormCustomerSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(912, 561);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewCustomers);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCustomerSearch";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Search";
            this.Load += new System.EventHandler(this.FormUserSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCustomers;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcCustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcContactNo;
        private System.Windows.Forms.DataGridViewButtonColumn dgcEdit;
        private System.Windows.Forms.DataGridViewButtonColumn dgcDelete;
    }
}