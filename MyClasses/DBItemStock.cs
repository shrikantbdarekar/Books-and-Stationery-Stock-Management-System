using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinBookStationaryStock19.MyClasses
{
    public class ItemStock
    {
        public int ItemID { get; set; }
        public string ItemFullName { get; set; }
        public int Quantity { get; set; }
        public int ReorderPoint { get; set; }
        public int OrderQuantity { get; set; }
        public int SaleQuantity { get; set; }
        public int StockQuantity { get; set; }

    }
}
