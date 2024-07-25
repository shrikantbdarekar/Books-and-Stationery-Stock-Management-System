
namespace WinBookStationaryStock19.Reports
{
    partial class FormReportMonthlySupplierOrder
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
            this.crystalReportViewerMain = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonShowReport = new System.Windows.Forms.Button();
            this.dateTimePickerToDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerFromDate = new System.Windows.Forms.DateTimePicker();
            this.labelSaleDate = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // crystalReportViewerMain
            // 
            this.crystalReportViewerMain.ActiveViewIndex = -1;
            this.crystalReportViewerMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerMain.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerMain.Location = new System.Drawing.Point(0, 51);
            this.crystalReportViewerMain.Margin = new System.Windows.Forms.Padding(4);
            this.crystalReportViewerMain.Name = "crystalReportViewerMain";
            this.crystalReportViewerMain.ShowCloseButton = false;
            this.crystalReportViewerMain.ShowCopyButton = false;
            this.crystalReportViewerMain.ShowExportButton = false;
            this.crystalReportViewerMain.ShowGotoPageButton = false;
            this.crystalReportViewerMain.ShowGroupTreeButton = false;
            this.crystalReportViewerMain.ShowLogo = false;
            this.crystalReportViewerMain.ShowParameterPanelButton = false;
            this.crystalReportViewerMain.ShowRefreshButton = false;
            this.crystalReportViewerMain.ShowTextSearchButton = false;
            this.crystalReportViewerMain.ShowZoomButton = false;
            this.crystalReportViewerMain.Size = new System.Drawing.Size(1184, 510);
            this.crystalReportViewerMain.TabIndex = 5;
            this.crystalReportViewerMain.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonShowReport);
            this.panel1.Controls.Add(this.dateTimePickerToDate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateTimePickerFromDate);
            this.panel1.Controls.Add(this.labelSaleDate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 51);
            this.panel1.TabIndex = 6;
            // 
            // buttonShowReport
            // 
            this.buttonShowReport.Location = new System.Drawing.Point(357, 12);
            this.buttonShowReport.Name = "buttonShowReport";
            this.buttonShowReport.Size = new System.Drawing.Size(124, 27);
            this.buttonShowReport.TabIndex = 10;
            this.buttonShowReport.Text = "Show Report";
            this.buttonShowReport.UseVisualStyleBackColor = true;
            this.buttonShowReport.Click += new System.EventHandler(this.buttonShowReport_Click);
            // 
            // dateTimePickerToDate
            // 
            this.dateTimePickerToDate.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerToDate.Location = new System.Drawing.Point(230, 13);
            this.dateTimePickerToDate.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerToDate.Name = "dateTimePickerToDate";
            this.dateTimePickerToDate.Size = new System.Drawing.Size(120, 24);
            this.dateTimePickerToDate.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "To";
            // 
            // dateTimePickerFromDate
            // 
            this.dateTimePickerFromDate.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFromDate.Location = new System.Drawing.Point(69, 13);
            this.dateTimePickerFromDate.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerFromDate.Name = "dateTimePickerFromDate";
            this.dateTimePickerFromDate.Size = new System.Drawing.Size(120, 24);
            this.dateTimePickerFromDate.TabIndex = 7;
            // 
            // labelSaleDate
            // 
            this.labelSaleDate.AutoSize = true;
            this.labelSaleDate.Location = new System.Drawing.Point(13, 16);
            this.labelSaleDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSaleDate.Name = "labelSaleDate";
            this.labelSaleDate.Size = new System.Drawing.Size(48, 18);
            this.labelSaleDate.TabIndex = 6;
            this.labelSaleDate.Text = "From ";
            // 
            // FormReportMonthlySupplierOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.crystalReportViewerMain);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormReportMonthlySupplierOrder";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monthly Supplier Order";
            this.Load += new System.EventHandler(this.FormReportMonthlySupplierOrder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonShowReport;
        private System.Windows.Forms.DateTimePicker dateTimePickerToDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerFromDate;
        private System.Windows.Forms.Label labelSaleDate;
    }
}