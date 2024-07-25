using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinBookStationaryStock19.MyClasses
{
    public class SupplierOrder
    {
        public int OrderID { get; set; }
        public int SupplierID { get; set; }
        public int OrderNo { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        //public string SupplierName { get; set; }
    }

}
