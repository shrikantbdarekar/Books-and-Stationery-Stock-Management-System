using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinBookStationaryStock19.MyClasses
{
    public class SaleDetail
    {
        public int SaleDetailID { get; set; }
        public int SaleID { get; set; }
        public int ItemID { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string ItemFullName { get; set; }
    }

}
