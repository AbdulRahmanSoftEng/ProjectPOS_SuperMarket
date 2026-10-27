using BackEnd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class clsEmployee : clsPerson
    {
        public enum enMode { AddNew, UpdateInfo};

        public enMode Mode;
        public decimal Salary { get; set; }
        public decimal BonusPerc { get; set; }

        public clsEmployee()
            :base()
        {
            this.Salary = 0;
            this.BonusPerc = 0;
            Mode = enMode.AddNew;
        }

        private clsEmployee(int ID, string FirstName, string LastName, string Phone, decimal Salary, decimal BonusPerc)
            : base(ID, FirstName, LastName, Phone)
        {
            this.Salary = Salary;
            this.BonusPerc = BonusPerc;
            Mode = enMode.UpdateInfo;
        }

        private clsEmployee(string FirstName, string LastName, string Phone, decimal Salary, decimal BonusPerc)
           : base(FirstName, LastName, Phone)
        {
            this.Salary = Salary;
            this.BonusPerc = BonusPerc;
            Mode = enMode.UpdateInfo;
        }

        public static DataTable GetAllEmployees()
        {
            return clsEmployeeBackEnd.GetAllEmployees();
        }

        private bool _AddNewEmployee()
        {
            return clsEmployeeBackEnd.AddNewEmployee(FirstName, LastName, Phone, Salary, BonusPerc);
        }

        private bool _UpdateEmployeeInfo()
        {
            return clsEmployeeBackEnd.UpdateEmployee(ID, FirstName, LastName, Phone, Salary, BonusPerc);
        }

        public static clsEmployee FindEmployeeByID(int EmployeeID)
        {
            string FirstName = "", LastName = "", Phone = "";
            decimal Salary = 0, BonusPerc = 0;
            if(clsEmployeeBackEnd.FindEmployeeByID(EmployeeID, ref FirstName, ref LastName, ref Phone, ref Salary, ref BonusPerc))
            {
                
                return new clsEmployee(EmployeeID, FirstName, LastName, Phone, Salary, BonusPerc);
            }
            return null;
        }

        public static bool DeleteEmployeeByID(int ID)
        {
            return clsEmployeeBackEnd.DeleteEmployeeByID(ID);
        }

        public static bool EmployeeIsExistByID(int ID)
        {
            return clsEmployeeBackEnd.EmployeeIsExistByID(ID);
        }

        public static DataTable FindEmployeeByNameUsingLike(string Name)
        {
            return clsEmployeeBackEnd.FindEmployeeByNameUsingLike(Name);
        }

        public static int GetCountEmployees()
        {
            return clsEmployeeBackEnd.GetCountEmployees();
        }

        public static int GetLastIDEmployee()
        {
            return clsEmployeeBackEnd.GetLastIDEmployee();
        }


        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    return _AddNewEmployee();

                case enMode.UpdateInfo:
                    return _UpdateEmployeeInfo();

                default:
                    return false;
            }
            return false;
        }
    }
}
