using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinBookStationaryStock19.MyClasses
{
    public class Item
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public int CategoryID { get; set; }
        public int Quantity { get; set; }
        public int ReorderPoint { get; set; }
        public decimal DPPrice { get; set; }
        public decimal MRPPrice { get; set; }


        public string CategoryName { get; set; }
        public string FullItemName { get; set; }
    }

}
