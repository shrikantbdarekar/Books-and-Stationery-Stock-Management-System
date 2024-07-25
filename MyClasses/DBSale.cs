using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinBookStationaryStock19.MyClasses
{
    public class Sale
    {
        public int SaleID { get; set; }
        public int BillNo { get; set; }
        public DateTime SaleDate { get; set; }
        public int CustomerID { get; set; }
        public decimal TotalAmount { get; set; }
    }

}
