
namespace WinBookStationaryStock19
{
    partial class FormCategorySearch
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
            this.dataGridViewCategories = new System.Windows.Forms.DataGridView();
            this.dgcCategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgcDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCategories
            // 
            this.dataGridViewCategories.AllowUserToAddRows = false;
            this.dataGridViewCategories.AllowUserToDeleteRows = false;
            this.dataGridViewCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCategories.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCategories.ColumnHeadersHeight = 30;
            this.dataGridViewCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcCategoryId,
            this.dgcCategoryName,
            this.dgcEdit,
            this.dgcDelete});
            this.dataGridViewCategories.Location = new System.Drawing.Point(18, 50);
            this.dataGridViewCategories.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewCategories.Name = "dataGridViewCategories";
            this.dataGridViewCategories.ReadOnly = true;
            this.dataGridViewCategories.Size = new System.Drawing.Size(476, 406);
            this.dataGridViewCategories.TabIndex = 0;
            this.dataGridViewCategories.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCategories_CellContentClick);
            // 
            // dgcCategoryId
            // 
            this.dgcCategoryId.DataPropertyName = "CategoryID";
            this.dgcCategoryId.HeaderText = "Category Id";
            this.dgcCategoryId.Name = "dgcCategoryId";
            this.dgcCategoryId.ReadOnly = true;
            this.dgcCategoryId.Visible = false;
            // 
            // dgcCategoryName
            // 
            this.dgcCategoryName.DataPropertyName = "CategoryName";
            this.dgcCategoryName.HeaderText = "Category Name";
            this.dgcCategoryName.Name = "dgcCategoryName";
            this.dgcCategoryName.ReadOnly = true;
            this.dgcCategoryName.Width = 200;
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
            this.buttonAdd.Text = "Add Category";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // FormCategorySearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(507, 469);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewCategories);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCategorySearch";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Category Search";
            this.Load += new System.EventHandler(this.FormUserSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCategories;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcCategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcCategoryName;
        private System.Windows.Forms.DataGridViewButtonColumn dgcEdit;
        private System.Windows.Forms.DataGridViewButtonColumn dgcDelete;
    }
}