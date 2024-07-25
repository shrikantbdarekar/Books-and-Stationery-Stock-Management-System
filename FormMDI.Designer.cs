
namespace WinBookStationaryStock19
{
    partial class FormMDI
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
            this.menuStripMDI = new System.Windows.Forms.MenuStrip();
            this.mnuSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuShopDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSupplier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSupplierOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSale = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReports = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRptCustomerList = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRptSupplierList = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSupplierOrderReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaleReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemStock = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProfitReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMDI.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMDI
            // 
            this.menuStripMDI.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripMDI.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSetting,
            this.mnuCustomer,
            this.mnuSupplier,
            this.mnuItem,
            this.mnuSupplierOrder,
            this.mnuSale,
            this.mnuReports,
            this.mnuExit});
            this.menuStripMDI.Location = new System.Drawing.Point(0, 0);
            this.menuStripMDI.Name = "menuStripMDI";
            this.menuStripMDI.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStripMDI.Size = new System.Drawing.Size(1200, 30);
            this.menuStripMDI.TabIndex = 0;
            this.menuStripMDI.Text = "menuStrip1";
            // 
            // mnuSetting
            // 
            this.mnuSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuShopDetails,
            this.mnuUsers,
            this.mnuCategory});
            this.mnuSetting.Name = "mnuSetting";
            this.mnuSetting.Size = new System.Drawing.Size(76, 24);
            this.mnuSetting.Text = "Setting |";
            // 
            // mnuShopDetails
            // 
            this.mnuShopDetails.Name = "mnuShopDetails";
            this.mnuShopDetails.Size = new System.Drawing.Size(180, 24);
            this.mnuShopDetails.Text = "Shop Details";
            this.mnuShopDetails.Click += new System.EventHandler(this.mnuShopDetails_Click);
            // 
            // mnuUsers
            // 
            this.mnuUsers.Name = "mnuUsers";
            this.mnuUsers.Size = new System.Drawing.Size(180, 24);
            this.mnuUsers.Text = "Users";
            this.mnuUsers.Click += new System.EventHandler(this.mnuUsers_Click);
            // 
            // mnuCategory
            // 
            this.mnuCategory.Name = "mnuCategory";
            this.mnuCategory.Size = new System.Drawing.Size(180, 24);
            this.mnuCategory.Text = "Category";
            this.mnuCategory.Click += new System.EventHandler(this.mnuCategory_Click);
            // 
            // mnuCustomer
            // 
            this.mnuCustomer.Name = "mnuCustomer";
            this.mnuCustomer.Size = new System.Drawing.Size(92, 24);
            this.mnuCustomer.Text = "Customer |";
            this.mnuCustomer.Click += new System.EventHandler(this.mnuCustomer_Click);
            // 
            // mnuSupplier
            // 
            this.mnuSupplier.Name = "mnuSupplier";
            this.mnuSupplier.Size = new System.Drawing.Size(84, 24);
            this.mnuSupplier.Text = "Supplier |";
            this.mnuSupplier.Click += new System.EventHandler(this.mnuSupplier_Click);
            // 
            // mnuItem
            // 
            this.mnuItem.Name = "mnuItem";
            this.mnuItem.Size = new System.Drawing.Size(59, 24);
            this.mnuItem.Text = "Item |";
            this.mnuItem.Click += new System.EventHandler(this.mnuItem_Click);
            // 
            // mnuSupplierOrder
            // 
            this.mnuSupplierOrder.Name = "mnuSupplierOrder";
            this.mnuSupplierOrder.Size = new System.Drawing.Size(126, 24);
            this.mnuSupplierOrder.Text = "Supplier Order |";
            this.mnuSupplierOrder.Click += new System.EventHandler(this.mnuSupplierOrder_Click);
            // 
            // mnuSale
            // 
            this.mnuSale.Name = "mnuSale";
            this.mnuSale.Size = new System.Drawing.Size(57, 24);
            this.mnuSale.Text = "Sale |";
            this.mnuSale.Click += new System.EventHandler(this.mnuSale_Click);
            // 
            // mnuReports
            // 
            this.mnuReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRptCustomerList,
            this.mnuRptSupplierList,
            this.mnuSupplierOrderReport,
            this.mnuSaleReport,
            this.mnuItemStock,
            this.mnuProfitReport});
            this.mnuReports.Name = "mnuReports";
            this.mnuReports.Size = new System.Drawing.Size(80, 24);
            this.mnuReports.Text = "Reports |";
            // 
            // mnuRptCustomerList
            // 
            this.mnuRptCustomerList.Name = "mnuRptCustomerList";
            this.mnuRptCustomerList.Size = new System.Drawing.Size(224, 24);
            this.mnuRptCustomerList.Text = "Customer List";
            this.mnuRptCustomerList.Click += new System.EventHandler(this.mnuRptCustomerList_Click);
            // 
            // mnuRptSupplierList
            // 
            this.mnuRptSupplierList.Name = "mnuRptSupplierList";
            this.mnuRptSupplierList.Size = new System.Drawing.Size(224, 24);
            this.mnuRptSupplierList.Text = "Supplier List";
            this.mnuRptSupplierList.Click += new System.EventHandler(this.mnuRptSupplierList_Click);
            // 
            // mnuSupplierOrderReport
            // 
            this.mnuSupplierOrderReport.Name = "mnuSupplierOrderReport";
            this.mnuSupplierOrderReport.Size = new System.Drawing.Size(224, 24);
            this.mnuSupplierOrderReport.Text = "Supplier Order Report";
            this.mnuSupplierOrderReport.Click += new System.EventHandler(this.mnuSupplierOrderReport_Click);
            // 
            // mnuSaleReport
            // 
            this.mnuSaleReport.Name = "mnuSaleReport";
            this.mnuSaleReport.Size = new System.Drawing.Size(224, 24);
            this.mnuSaleReport.Text = "Sale Report";
            this.mnuSaleReport.Click += new System.EventHandler(this.mnuSaleReport_Click);
            // 
            // mnuItemStock
            // 
            this.mnuItemStock.Name = "mnuItemStock";
            this.mnuItemStock.Size = new System.Drawing.Size(224, 24);
            this.mnuItemStock.Text = "Item Stock";
            this.mnuItemStock.Click += new System.EventHandler(this.mnuItemStock_Click);
            // 
            // mnuProfitReport
            // 
            this.mnuProfitReport.Name = "mnuProfitReport";
            this.mnuProfitReport.Size = new System.Drawing.Size(224, 24);
            this.mnuProfitReport.Text = "Profit Report";
            this.mnuProfitReport.Click += new System.EventHandler(this.mnuProfitReport_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(45, 24);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // FormMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.menuStripMDI);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStripMDI;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMDI";
            this.Text = "Project Name";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMDI_Load);
            this.menuStripMDI.ResumeLayout(false);
            this.menuStripMDI.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMDI;
        private System.Windows.Forms.ToolStripMenuItem mnuSetting;
        private System.Windows.Forms.ToolStripMenuItem mnuShopDetails;
        private System.Windows.Forms.ToolStripMenuItem mnuUsers;
        private System.Windows.Forms.ToolStripMenuItem mnuSupplier;
        private System.Windows.Forms.ToolStripMenuItem mnuSupplierOrder;
        private System.Windows.Forms.ToolStripMenuItem mnuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSale;
        private System.Windows.Forms.ToolStripMenuItem mnuReports;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuCategory;
        private System.Windows.Forms.ToolStripMenuItem mnuCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnuRptCustomerList;
        private System.Windows.Forms.ToolStripMenuItem mnuRptSupplierList;
        private System.Windows.Forms.ToolStripMenuItem mnuSupplierOrderReport;
        private System.Windows.Forms.ToolStripMenuItem mnuSaleReport;
        private System.Windows.Forms.ToolStripMenuItem mnuItemStock;
        private System.Windows.Forms.ToolStripMenuItem mnuProfitReport;
    }
}