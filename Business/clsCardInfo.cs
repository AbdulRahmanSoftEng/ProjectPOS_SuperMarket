using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class clsCardInfo
    {

        public int Id { get; set; }
        public string Barcode { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Image { get; set; }
        
        public clsCardInfo(int Id, string Barcode, string Name, float Price, string Image)
        {
            this.Id = Id;
            this.Barcode = Barcode;
            this.Name = Name;
            this.Price = Price;
            this.Image = Image;
        }
    }
}
