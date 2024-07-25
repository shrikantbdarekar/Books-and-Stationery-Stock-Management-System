
namespace WinBookStationaryStock19
{
    partial class FormItemAddEdit
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.textBoxMRPPrice = new System.Windows.Forms.TextBox();
            this.labelMRPPrice = new System.Windows.Forms.Label();
            this.textBoxDPPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxReorderPoint = new System.Windows.Forms.TextBox();
            this.labelReorderPoint = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelCategory = new System.Windows.Forms.Label();
            this.textBoxItemName = new System.Windows.Forms.TextBox();
            this.labelItemName = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.Controls.Add(this.comboBoxCategory);
            this.panelMain.Controls.Add(this.textBoxMRPPrice);
            this.panelMain.Controls.Add(this.labelMRPPrice);
            this.panelMain.Controls.Add(this.textBoxDPPrice);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.textBoxReorderPoint);
            this.panelMain.Controls.Add(this.labelReorderPoint);
            this.panelMain.Controls.Add(this.textBoxQuantity);
            this.panelMain.Controls.Add(this.labelQuantity);
            this.panelMain.Controls.Add(this.buttonCancel);
            this.panelMain.Controls.Add(this.buttonSave);
            this.panelMain.Controls.Add(this.labelCategory);
            this.panelMain.Controls.Add(this.textBoxItemName);
            this.panelMain.Controls.Add(this.labelItemName);
            this.panelMain.Location = new System.Drawing.Point(12, 12);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(639, 187);
            this.panelMain.TabIndex = 0;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(164, 50);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(442, 26);
            this.comboBoxCategory.TabIndex = 3;
            // 
            // textBoxMRPPrice
            // 
            this.textBoxMRPPrice.Location = new System.Drawing.Point(511, 112);
            this.textBoxMRPPrice.Name = "textBoxMRPPrice";
            this.textBoxMRPPrice.Size = new System.Drawing.Size(95, 24);
            this.textBoxMRPPrice.TabIndex = 11;
            // 
            // labelMRPPrice
            // 
            this.labelMRPPrice.AutoSize = true;
            this.labelMRPPrice.Location = new System.Drawing.Point(380, 115);
            this.labelMRPPrice.Name = "labelMRPPrice";
            this.labelMRPPrice.Size = new System.Drawing.Size(42, 18);
            this.labelMRPPrice.TabIndex = 10;
            this.labelMRPPrice.Text = "MRP";
            // 
            // textBoxDPPrice
            // 
            this.textBoxDPPrice.Location = new System.Drawing.Point(164, 112);
            this.textBoxDPPrice.Name = "textBoxDPPrice";
            this.textBoxDPPrice.Size = new System.Drawing.Size(95, 24);
            this.textBoxDPPrice.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "DP";
            // 
            // textBoxReorderPoint
            // 
            this.textBoxReorderPoint.Location = new System.Drawing.Point(511, 82);
            this.textBoxReorderPoint.Name = "textBoxReorderPoint";
            this.textBoxReorderPoint.Size = new System.Drawing.Size(95, 24);
            this.textBoxReorderPoint.TabIndex = 7;
            // 
            // labelReorderPoint
            // 
            this.labelReorderPoint.AutoSize = true;
            this.labelReorderPoint.Location = new System.Drawing.Point(380, 85);
            this.labelReorderPoint.Name = "labelReorderPoint";
            this.labelReorderPoint.Size = new System.Drawing.Size(104, 18);
            this.labelReorderPoint.TabIndex = 6;
            this.labelReorderPoint.Text = "Reorder Point ";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(164, 82);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(95, 24);
            this.textBoxQuantity.TabIndex = 5;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(33, 85);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(66, 18);
            this.labelQuantity.TabIndex = 4;
            this.labelQuantity.Text = "Quantity ";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(245, 142);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 27);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(164, 142);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 27);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(33, 54);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(68, 18);
            this.labelCategory.TabIndex = 2;
            this.labelCategory.Text = "Category";
            // 
            // textBoxItemName
            // 
            this.textBoxItemName.Location = new System.Drawing.Point(164, 20);
            this.textBoxItemName.Name = "textBoxItemName";
            this.textBoxItemName.Size = new System.Drawing.Size(442, 24);
            this.textBoxItemName.TabIndex = 1;
            // 
            // labelItemName
            // 
            this.labelItemName.AutoSize = true;
            this.labelItemName.Location = new System.Drawing.Point(33, 23);
            this.labelItemName.Name = "labelItemName";
            this.labelItemName.Size = new System.Drawing.Size(80, 18);
            this.labelItemName.TabIndex = 0;
            this.labelItemName.Text = "Item Name";
            // 
            // FormItemAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(663, 211);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormItemAddEdit";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item Details";
            this.Load += new System.EventHandler(this.FormItemAddEdit_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.TextBox textBoxItemName;
        private System.Windows.Forms.Label labelItemName;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.TextBox textBoxMRPPrice;
        private System.Windows.Forms.Label labelMRPPrice;
        private System.Windows.Forms.TextBox textBoxDPPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxReorderPoint;
        private System.Windows.Forms.Label labelReorderPoint;
        private System.Windows.Forms.ComboBox comboBoxCategory;
    }
}