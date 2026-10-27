using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class clsProductBarcode
    {
        public string ProductName { get; set; }
        public string Barcode { get; set; }
        public int PrintQty { get; set; }

        public clsProductBarcode(string productName, string barcode, int printQty)
        {
            ProductName = productName;
            Barcode = barcode;
            PrintQty = printQty;
        }
    }
}
