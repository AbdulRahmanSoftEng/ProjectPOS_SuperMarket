using BackEnd;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Business
{
    public class clsProduct
    {
        public enum enMode { AddNew, UpdateInfo};
        public enMode Mode;
        public int Id { get; set; }
        public string Barcode { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public int Category { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public byte IsBarcode { get; set; }

        public clsProduct()
        {
            this.Id = -1;
            this.Barcode = "";
            this.Name = "";
            this.Price = 0;
            this.Quantity = 0;
            this.Description = "";
            this.Image = "";
            IsBarcode = 0;
            Mode = enMode.AddNew;
        }

        public clsProduct(int ID, string Barcode, string Name, float Price, int Quantity, int Category, string Description, string Image, byte IsBarcode)
        {
            this.Id = ID;
            this.Barcode = Barcode;
            this.Name = Name;
            this.Price = Price;
            this.Quantity = Quantity;
            this.Category = Category;
            this.Description = Description;
            this.Image = Image;
            this.IsBarcode = IsBarcode;

            Mode = enMode.UpdateInfo;
        }

        public clsProduct(string Barcode, string Name, float Price, int Quantity, int Category, string Description, string Image, byte IsBarcode)
        {
            this.Barcode = Barcode;
            this.Name = Name;
            this.Price = Price;
            this.Quantity = Quantity;
            this.Category = Category;
            this.Description = Description;
            this.Image = Image;
            this.IsBarcode = IsBarcode;

            Mode = enMode.UpdateInfo;
        }

        public clsProduct(int Id, string Barcode, string Name, float Price, int Qty)
        {
            this.Id = Id;
            this.Barcode = Barcode;
            this.Name = Name;
            this.Price = Price;
            this.Quantity = Qty;
           

            Mode = enMode.UpdateInfo;
        }

        public clsProduct(string Barcode, string Name, float Price, int Qty, byte IsBarcode)
        {
            this.Barcode = Barcode;
            this.Name = Name;
            this.Price = Price;
            this.Quantity = Qty;
            this.IsBarcode = IsBarcode;

            Mode = enMode.UpdateInfo;
        }

        public clsProduct(int Id, string Name, float Price, int Qty, byte IsBarcode)
        {
            this.Id = Id;
            this.Name = Name;
            this.Price = Price;
            this.Quantity = Qty;
            this.IsBarcode = IsBarcode;

            Mode = enMode.UpdateInfo;
        }

        public static DataTable GetAllProducts()
        {
            return clsProductBackEnd.GetAllProducts();
        } 
        
        public static DataTable GetAllProducts3Column()
        {
            return clsProductBackEnd.GetAllProducts3Column();
        }

        public static DataTable FindProductsByNameUsingLike(string Name)
        {
            return clsProductBackEnd.GetAllProductsByNameUsingLike(Name);
        }

        public static DataTable GetAllProductsByCategoryNameUsingLike(string CategoryID)
        {
            return clsProductBackEnd.GetAllProductsByCategoryNameUsingLike(CategoryID);
        }

        public static clsProduct FindProductByBarcode3Columns(string Barcode)
        {
            string Name = "";
            float Price = 0;
            int Quantity = 0;
            byte IsBarcode = 0;

            if (clsProductBackEnd.FindProductByBarcode(ref Barcode, ref Name, ref Price, ref Quantity, ref IsBarcode))
            {
                return new clsProduct(Barcode, Name, Price, Quantity, IsBarcode);
            }
            return null;
        }

        public static clsProduct FindProductById3Columns(int Id)
        {
            string Name = "";
            float Price = 0;
            int Quantity = 0;
            byte IsBarcode = 0;

            if (clsProductBackEnd.FindProductById(Id, ref Name, ref Price, ref Quantity, ref IsBarcode))
            {
                return new clsProduct(Id, Name, Price, Quantity, IsBarcode);
            }
            return null;
        }

        public static DataTable GetAllProductIsNotHasBarcode(byte IsBarcode = 1)
        {
            return clsProductBackEnd.GetAllProductIsNotHasBarcode(IsBarcode);
        }

        public bool _AddNewProduct()
        {
            if(Image != "")
            {
                Image = new clsFileHandling().CopyImageToDirectory(Image);
            }

            return clsProductBackEnd.AddNewProduct(Barcode, Name, Price, Quantity, Category, Description, Image, IsBarcode);
        }

        public bool _UpdateProductInfo()
        {
            if (Image != "")
            {
                Image = new clsFileHandling(Id).CopyImageToDirectory(Image);
            }

            return clsProductBackEnd.UpdateProduct(Id, Barcode, Name, Price, Quantity, Category, Description, Image, IsBarcode);
        }

        public static bool DeleteProductByID(int ID)
        {
            return clsProductBackEnd.DeleteProductByID(ID);
        }

        public static bool DeleteProductByBarcode(string Barcode)
        {
            return clsProductBackEnd.DeleteProductByBarcode(Barcode);
        }

        public static clsProduct FindProductByBarcode(string Barcode)
        {
            int ID = -1;
            string Name = "";
            float Price = 0;
            int Quantity = 0;
            int Category = 0;
            string Description = "";
            string Image = "";
            byte IsBarcode = 0;

            if(clsProductBackEnd.FindProductByBarcode(ref ID, ref Barcode, ref Name, ref Price, ref Quantity, ref Category, ref Description, ref Image, ref IsBarcode))
            {
                if(Image != "")
                {
                    Image = clsShared.DefaultPathImages +"\\"+Image;  
                }
                return new clsProduct(ID, Barcode,  Name,  Price,  Quantity, Category,  Description,  Image, IsBarcode);
            }
            return null;
        }

        public static clsProduct FindProductByID(int ID)
        {
            string Barcode = "";
            string Name = "";
            float Price = 0;
            int Quantity = 0;
            int Category = 0;
            string Description = "";
            string Image = "";
            byte IsBarcode = 0;

            if (clsProductBackEnd.FindProductByID(ref ID, ref Barcode, ref Name, ref Price, ref Quantity, ref Category, ref Description, ref Image, ref IsBarcode))
            {
                if (Image != "")
                {
                    Image = clsShared.DefaultPathImages + "\\" + Image;
                }
                return new clsProduct(ID, Barcode, Name, Price, Quantity, Category, Description, Image, IsBarcode);
            }
            return null;
        }

        public static bool IsProductExistByID(int ID)
        {
            return clsProductBackEnd.IsProductIsExistByID(ID);
        }
        public static bool IsProductExistByBarcode(string Barcode)
        {
            return clsProductBackEnd.IsProductExistByBarcode(Barcode);
        } 
        
        public static bool IsProductExistByBarcodeAndName(string Barcode, string Name)
        {
            return clsProductBackEnd.IsProductExistByBarcodeAndName(Barcode, Name);
        }

        public static DataTable GetAllProductUsingLikeByName(string Name)
        {
            return clsProductBackEnd.GetAllProductUsingLikeByName(Name);
        } 
        
        public static DataTable GetAllProductUsingLikeByNameOrBarcode(string value)
        {
            return clsProductBackEnd.GetAllProductUsingLikeByNameOrBarcode(value);
        }
         

        public static clsProduct GetProductByBarcode(string Barcode)
        {
            int Id = -1;
            string Name = "";
            float Price = 0;
            int Qty = -1;

            if (clsProductBackEnd.FindProductByBarcode(ref Id, ref Barcode, ref Name, ref Price, ref Qty))
            {
                return new clsProduct(Id, Barcode, Name, Price, Qty);

            }
            return null;
        }



        public static DataTable GetAllProductsRestrictRequest()
        {
            return clsProductBackEnd.GetAllProductsRestrictRequest();
        }

        public static DataTable GetAllProductsRestrictRequestUsingLike(string Name)
        {
            return clsProductBackEnd.GetAllProductsRestrictRequestUsingLike(Name);
        }

        public static int GetProductIDByName(string Name)
        {
            return clsProductBackEnd.GetProductIDByName(Name);
        }

        public static int GetLastIDProduct()
        {
            return clsProductBackEnd.GeLastIDProduct();
        }

        public static int GetQuantityItemByProducts(string Barcode)
        {
            return clsProductBackEnd.GetQuantityItemByProducts(Barcode);
        } 
        
        public static int GetQuantityItemByName(string Name)
        {
            return clsProductBackEnd.GetQuantityItemByName(Name);
        } 
        
        public static bool UpdateNewQtyItemByName(string Name, int NewQty)
        {
            return clsProductBackEnd.UpdateNewQtyItemByName(Name, NewQty);
        } 
        
        public static int GetCountProducts()
        {
            return clsProductBackEnd.GetCountProducts();
        }
        
        public static string GetBarcodeByName(string Name)
        {
            return clsProductBackEnd.GetBarcodeByName(Name);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    return _AddNewProduct();
                        

                case enMode.UpdateInfo:
                    return _UpdateProductInfo();
                     
                default:
                    return false;

            }
            return false;
        }
    }
}
