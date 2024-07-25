
namespace WinBookStationaryStock19
{
    partial class FormUserSearch
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
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.dgcUserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgcDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.AllowUserToDeleteRows = false;
            this.dataGridViewUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewUsers.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewUsers.ColumnHeadersHeight = 30;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcUserId,
            this.dgcUserName,
            this.dgcPassword,
            this.dgcRole,
            this.dgcEdit,
            this.dgcDelete});
            this.dataGridViewUsers.Location = new System.Drawing.Point(18, 50);
            this.dataGridViewUsers.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.ReadOnly = true;
            this.dataGridViewUsers.Size = new System.Drawing.Size(730, 406);
            this.dataGridViewUsers.TabIndex = 0;
            this.dataGridViewUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsers_CellContentClick);
            // 
            // dgcUserId
            // 
            this.dgcUserId.DataPropertyName = "UserID";
            this.dgcUserId.HeaderText = "User Id";
            this.dgcUserId.Name = "dgcUserId";
            this.dgcUserId.Visible = false;
            // 
            // dgcUserName
            // 
            this.dgcUserName.DataPropertyName = "Username";
            this.dgcUserName.HeaderText = "User Name";
            this.dgcUserName.Name = "dgcUserName";
            this.dgcUserName.Width = 150;
            // 
            // dgcPassword
            // 
            this.dgcPassword.DataPropertyName = "UserPassword";
            this.dgcPassword.HeaderText = "Password";
            this.dgcPassword.Name = "dgcPassword";
            this.dgcPassword.Width = 150;
            // 
            // dgcRole
            // 
            this.dgcRole.DataPropertyName = "UserRole";
            this.dgcRole.HeaderText = "Role";
            this.dgcRole.Name = "dgcRole";
            this.dgcRole.Width = 150;
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
            this.buttonAdd.Text = "Add New User";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // FormUserSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(761, 469);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewUsers);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUserSearch";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Search";
            this.Load += new System.EventHandler(this.FormUserSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcUserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRole;
        private System.Windows.Forms.DataGridViewButtonColumn dgcEdit;
        private System.Windows.Forms.DataGridViewButtonColumn dgcDelete;
    }
}