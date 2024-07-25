using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinBookStationaryStock19.MyClasses
{
    public static class MyConnectioString
    {
        public static string Value 
        { 
            get 
            {
                // Without user id and password
                // return Properties.Settings.Default.ConnestionStringShort;
                // return "Server=.\\sqlexpress19;Database=BookStationaryStockDB;Integrated Security=True;";

                // With user id and password
                // return Properties.Settings.Default.ConnestionStringFull;
                return "Server=.\\sqlexpress19;Database=BookStationaryStockDB;User Id=sa;Password=sqlexpress@19;";
            } 
        }
    }
}
