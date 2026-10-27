using BackEnd;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class clsCustomer: clsPerson
    {
        public enum enMode { AddNew, UpdateInfo };

        public enMode Mode;

        public string Address { get; set; }

        public clsCustomer()
            : base()
        {
            this.Address = "";
            Mode = enMode.AddNew;
        }
        private clsCustomer(int ID, string FirstName, string LastName, string Phone, string Address)
            : base(ID, FirstName, LastName, Phone)
        {
            this.Address = Address;

            Mode = enMode.UpdateInfo;
        }

        private clsCustomer(string FirstName, string LastName, string Phone, string Address)
           : base(FirstName, LastName, Phone)
        {
            this.Address = Address;

            Mode = enMode.UpdateInfo;
        }

        public static DataTable GetAllCustomers()
        {
            return clsCustomerBackEnd.GetAllCustomers();
        }

        private bool _AddNewCustomer()
        {
            return clsCustomerBackEnd.AddNewCustomer(FirstName, LastName, Phone, Address);
        }

        private bool _UpdateCustomerInfo()
        {
            return clsCustomerBackEnd.UpdateCustomer(ID, FirstName, LastName, Phone, Address);
        }

        public static clsCustomer FindCustomerByID(int CustomerID)
        {
            string FirstName = "", LastName = "", Phone = "", Address = "";
 
            if (clsCustomerBackEnd.FindCustomerByID(CustomerID, ref FirstName, ref LastName, ref Phone, ref Address))
            {

                return new clsCustomer(CustomerID, FirstName, LastName, Phone, Address);
            }
            return null;
        } 
        
        public static clsCustomer FindCustomerByID2(int CustomerID)
        {
            string FirstName = "", LastName = "", Phone = "", Address = "";
 
            if (clsCustomerBackEnd.FindCustomerByID2(CustomerID, ref FirstName, ref LastName, ref Phone, ref Address))
            {

                return new clsCustomer(CustomerID, FirstName, LastName, Phone, Address);
            }
            return null;
        }

        public static bool DeleteCustomerByID(int ID)
        {
            return clsCustomerBackEnd.DeleteCustomerByID(ID);
        }

        public static bool CustomerIsExistByID(int ID)
        {
            return clsCustomerBackEnd.CustomerIsExistByID(ID);
        }

        public static DataTable FindCustomersByFirstNameUsingLike(string FirstName)
        {
            return clsCustomerBackEnd.FindCustomersByFirstNameUsingLike(FirstName);
        }

        public static DataTable FindCustomersByLastNameUsingLike(string LastName)
        {
            return clsCustomerBackEnd.FindCustomersByLastNameUsingLike(LastName);
        }

        public static DataTable FindCustomersByPhoneUsingLike(string Phone)
        {
            return clsCustomerBackEnd.FindCustomersByPhoneUsingLike(Phone);
        }

       
        public static int GetCustomerIDByPersonID(int PersonID)
        {
            return clsCustomerBackEnd.GetCustomerIDByPersonID(PersonID);
        }

        public static int GetCountCustomers()
        {
            return clsCustomerBackEnd.GetCountCustomers();
        }

        public static int GetLastIDCustomer()
        {
            return clsCustomerBackEnd.GetLastIDCustomer();
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    return _AddNewCustomer();
                       

                case enMode.UpdateInfo:
                    return _UpdateCustomerInfo();
                      

                default:
                    return false;
            }
            return false;
        }
    }
}
