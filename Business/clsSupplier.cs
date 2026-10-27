using BackEnd;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class clsSupplier: clsPerson
    {
        public enum enMode { AddNew, UpdateInfo };
        public enum enTypeSearch { FindByFirstName = 0, FindByLastName = 1, FindByPhone = 2 };
        public enMode Mode;

        public string Address { get; set; }

        public clsSupplier()
            : base()
        {
            this.Address = "";
            Mode = enMode.AddNew;
        }
        private clsSupplier(int ID, string FirstName, string LastName, string Phone, string Address)
            : base(ID, FirstName, LastName, Phone)
        {
            this.Address = Address;

            Mode = enMode.UpdateInfo;
        }

        private clsSupplier(string FirstName, string LastName, string Phone, string Address)
           : base(FirstName, LastName, Phone)
        {
            this.Address = Address;

            Mode = enMode.UpdateInfo;
        }

        public static DataTable GetAllSuppliers()
        {
            return clsSupplierBackEnd.GetAllSuppliers();
        }

        private bool _AddNewSupplier()
        {
            return clsSupplierBackEnd.AddNewSupplier(FirstName, LastName, Phone, Address);
        }

        private bool _UpdateSupplierInfo()
        {
            return clsSupplierBackEnd.UpdateSupplier(ID, FirstName, LastName, Phone, Address);
        }

        public static clsSupplier FindSupplierByID(int SupplierID)
        {
            string FirstName = "", LastName = "", Phone = "", Address = "";

            if (clsSupplierBackEnd.FindSupplierByID(SupplierID, ref FirstName, ref LastName, ref Phone, ref Address))
            {

                return new clsSupplier(SupplierID, FirstName, LastName, Phone, Address);
            }
            return null;
        }

        public static bool DeleteSupplierByID(int ID)
        {
            return clsSupplierBackEnd.DeleteSupplierByID(ID);
        }

        public static bool SupplierIsExistByID(int ID)
        {
            return clsSupplierBackEnd.SupplierIsExistByID(ID);
        }

        public static DataTable FindSuppliersUsingLike(string Text, string TypeSearch)
        {
            return clsSupplierBackEnd.FindSuppliersUsingLike(Text, TypeSearch);
        }

        public static DataTable GetAllSuppliersFirstName()
        {
            return clsSupplierBackEnd.GetAllSuppliersFirstName();
        }

        public static int GetSupplierIDByFirstName(string FirstName)
        {
            return clsSupplierBackEnd.GetSupplierIDByFirstName(FirstName);
        }

        public static int GetCountSuppliers()
        {
            return clsSupplierBackEnd.GetCountSuppliers();
        }

        public static int GetLastSuppliersID()
        {
            return clsSupplierBackEnd.GetLastSuppliersID();
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    return _AddNewSupplier();

                case enMode.UpdateInfo:

                    return _UpdateSupplierInfo();

                default:
                    return false;
             }
            return false;
        }
    }
}
