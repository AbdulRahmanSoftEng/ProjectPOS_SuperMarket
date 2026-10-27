using BackEnd;
using iText.Kernel.Actions.Events;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

namespace Business
{
    public class clsProfileStock
    {
        public enum enMode { Add, Update};
        public enMode Mode;

        public int Id { get; set; }
        public string Title { get; set; } 
        public string Owner { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string InFrontOfStock { get; set; }
        public string Location { get; set; }
        public string WebSite { get; set; }
        public string Logo { get; set; }

        public clsProfileStock()
        {
            Mode = enMode.Add;
        }
        public clsProfileStock(int id, string title, string owner, string city, string street, string inFrontOfStock, string location, string webSite, string logo)
        {
            Id = id;
            Title = title;
            Owner = owner;
            City = city;
            Street = street;
            InFrontOfStock = inFrontOfStock;
            Location = location;
            WebSite = webSite;
            Logo = logo;

            Mode = enMode.Update;
        }

        public static DataTable GetInfoProfileStock()
        {
            return clsSettingBackEnd.GetInfoProfileStock();
        }

        public static clsProfileStock FindProfileStock(int ID)
        {
            string Title = "";
            string Owner = "";
            string City = "";
            string Street = "";
            string InFrontOfStock = "";
            string Location = "";
            string WebSite = "";
            string Logo = "";

            if (clsSettingBackEnd.FindProfileStock(ref ID, ref Title, ref Owner, ref City, ref Street, ref InFrontOfStock, ref Location, ref WebSite, ref Logo))
            {
                if (Logo != "")
                {
                    Logo = clsShared.DefaultPathImages + "\\" + Logo;
                }

                return new clsProfileStock(ID, Title, Owner, City, Street, InFrontOfStock, Location, WebSite, Logo);
            }
            return null;

        }

        public bool AddProfileStock()
        {
            if (Logo != "")
            {
                Logo = new clsFileHandling().CopyImageToDirectory(Logo);
            }

            if (clsSettingBackEnd.AddProfileStock(Id, Title, Owner, City, Street, InFrontOfStock, Location, WebSite, Logo))
            {
                return true;
            }
            return false;

        }

        public bool UpdateProfileStock()
        {
            if (Logo != "")
            {
                Logo = new clsFileHandling(Id).CopyImageToDirectory(Logo);
            }

            if (clsSettingBackEnd.UpdateProfile( Id, Title,  Owner,  City,  Street,  InFrontOfStock,  Location,  WebSite,  Logo))
            {
                return true;
            }
            return false;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.Add:
                    
                        return AddProfileStock();
                    

                case enMode.Update:
                    
                        return UpdateProfileStock();
                    
            }

            return false;
        }
    }
}
