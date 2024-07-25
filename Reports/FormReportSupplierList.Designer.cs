
namespace WinBookStationaryStock19.Reports
{
    partial class FormReportSupplierList
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
            this.SuspendLayout();
            // 
            // crystalReportViewerMain
            // 
            this.crystalReportViewerMain.ActiveViewIndex = -1;
            this.crystalReportViewerMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerMain.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerMain.Location = new System.Drawing.Point(0, 0);
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
            this.crystalReportViewerMain.Size = new System.Drawing.Size(800, 450);
            this.crystalReportViewerMain.TabIndex = 1;
            this.crystalReportViewerMain.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FormReportSupplierList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystalReportViewerMain);
            this.Name = "FormReportSupplierList";
            this.ShowIcon = false;
            this.Text = "Report: Supplier List";
            this.Load += new System.EventHandler(this.FormReportSupplierList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerMain;
    }
}