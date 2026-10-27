using System;
using System.Data;
using BackEnd;

namespace Business
{

    public class clsUser: clsPerson
    {
        public enum enMode { AddNew, UpdateInfo}

        public enMode Mode;
        public string Username { get; set; }
        public string Password { get; set; }
        public Int64 Permission { get; set; }
        public string FullName { get; set; }

        public clsUser()
        {
            this.Username = "";
            this.Password = "";
            this.Permission = 0;
           
            Mode = enMode.AddNew;
        }

        private clsUser(int ID, string firstName, string lastName, string phone, string username, string password, Int64 permission)
        :base(ID, firstName, lastName,phone)
        {
            this.Username = username;
            this.Password = password;
            this.Permission = permission;

            Mode = enMode.UpdateInfo;
        }

        private clsUser(string firstName, string lastName, string phone, string username, string password, Int64 permission)
        : base(firstName, lastName, phone)
        {
            this.Username = username;
            this.Password = password;
            this.Permission = permission;

            Mode = enMode.UpdateInfo;
        }

        private clsUser(int Id, string username, string password, Int64 permission, string FullName)
        {
            this.ID = Id;
            this.FullName = FullName;
            this.Username = username;
            this.Password = password;
            this.Permission = permission;

            Mode = enMode.UpdateInfo;
        }

        public static DataTable GetAllUsers()
        {
            return clsUsersBackEnd.GetAllUsers();
        }

        private bool _AddNewUser()
        {
            this.ID = clsUsersBackEnd.AddUser(
                FirstName,
                LastName,
                Phone,
                Username,
                Password,
                Permission);

            return this.ID != -1;
        }

        public static bool DeleteUser(int ID)
        {
            return clsUsersBackEnd.DeleteUser(ID);
        }

        public static clsUser FindUserByID(int ID)
        {
            string FirstName = "", LastName = "", Phone = "", Username = "", Password = "";
            Int64 Permission = -1;

            if(clsUsersBackEnd.FindUserByID(ID, ref FirstName, ref LastName, ref Phone, ref Username, ref Password, ref Permission))
            {
                return new clsUser(ID, FirstName, LastName,Phone,Username, Password, Permission);
            }
            
            return null;
        }
        
        public static clsUser FindUserByPersonID(int ID)
        {
            string FirstName = "", LastName = "", Phone = "", Username = "", Password = "";
            Int64 Permission = -1;

            if(clsUsersBackEnd.FindUserByPersonID(ID, ref FirstName, ref LastName, ref Phone, ref Username, ref Password, ref Permission))
            {
                return new clsUser(ID, FirstName, LastName,Phone,Username, Password, Permission);
            }
            
            return null;
        }

        public static clsUser FindUserByName(string Name)
        {
            int ID = -1;
            string FirstName = "", LastName = "", Phone = "", Username = "", Password = "";
            Int64 Permission = -1;

            if (clsUsersBackEnd.FindUserByName(ref ID,ref FirstName, ref LastName, ref Phone, ref Username, ref Password, ref Permission))
            {
                return new clsUser(ID, FirstName, LastName, Phone, Username, Password, Permission);
            }

            return null;
        }

        public static DataTable GetAllUserByNameUsingLike(string Name)
        {

            return clsUsersBackEnd.GetAllUserByNameUsingLike(Name);

        } 
        
        public static DataTable GetAllUserByLastNameUsingLike(string Name)
        {

            return clsUsersBackEnd.GetAllUserByLastNameUsingLike(Name);

        }  
        
        public static DataTable GetAllUserByPhoneUsingLike(string Name)
        {

            return clsUsersBackEnd.GetAllUserByPhoneUsingLike(Name);

        }

        public static clsUser FindUserByUserAndPass(string User, string Pass)
        {   
            int ID = -1;
            Int64 Permission = -1;
            string FullName = "";
            if (clsUsersBackEnd.FindUserByUserAndPass(ref ID, ref User, ref Pass, ref Permission, ref FullName))
            {
                return new clsUser(ID, User, Pass, Permission, FullName);
            }

            return null;
        }

        public static bool UserIsExistByID(int ID)
        {
            
            if(clsUsersBackEnd.UserIsExistByID(ID))
            {
                return true;
            }

            return false;
        }

        public static bool UserIsExistByName(string Name)
        {

            if (clsUsersBackEnd.UserIsExistByName(Name))
            {
                return true;
            }

            return false;
        }

        public static bool UserIsExistByUserAndPass(string Username, string Password)
        {

            if (clsUsersBackEnd.UserIsExistByUserAndPass(Username, Password))
            {
                return true;
            }

            return false;
        }

        public static int GetCountUsers()
        {
           return clsUsersBackEnd.GetCountUsers();
        }

        private bool _UpdateUserInfo()
        {
            return clsUsersBackEnd.UpdateUserInfo(
                ID,
                FirstName,
                LastName,
                Phone,
                Username,
                Password,
                Permission
                );
        }

        public static int GetUserIDByName(string Username)
        {
            return clsUsersBackEnd.GetUserIDByUsername(Username);
        }
        
        public static int GetUserIDByPersonID(int PersonID)
        {
            return clsUsersBackEnd.GetUserIDByPersonID(PersonID);
        }

        public static int GetLastIDUser()
        {
            return clsUsersBackEnd.GetLastIDUser();
        } 
        
        public static int AddLoginHistoryLoginDate(int UserID)
        {
            return clsUsersBackEnd.AddLoginHistoryLoginDate(UserID);
        } 
        
        public static int UpdateLoginHistoryLoginExit(int ID)
        {
            return clsUsersBackEnd.UpdateLoginHistoryLoginExit(ID);
        }

        public bool Save()
        {
            
            switch (Mode)
            {
                case enMode.AddNew:

                    return _AddNewUser();

                case enMode.UpdateInfo:

                    return _UpdateUserInfo();
                     

                default:

                return false;
            }

            return false;
        }
    }
}
