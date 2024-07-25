using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinBookStationaryStock19
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                Reports.FormReportCustomerList RptObj = new Reports.FormReportCustomerList();
                Application.DoEvents();

                FormLogin FormLoginObj = new FormLogin();
                FormLoginObj.ShowDialog();

                if (FormLoginObj.DialogResult == DialogResult.OK)
                {
                    FormMDI FormMDIObj = new FormMDI();
                    FormMDIObj.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error program.cs : " + ex.Message);
            }
        }
    }
}
