using BackEnd;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class clsCategory
    {
        public enum enMode { AddNew, UpdateInfo}
        public enMode Mode;
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public clsCategory()
        {
            this.Id = -1;
            this.Name = "";
            this.Description = "";

            Mode = enMode.AddNew;
        }

        public clsCategory(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
            Mode = enMode.UpdateInfo;

        }

        public clsCategory(string name, string description)
        {
            this.Name = name;
            this.Description = description;

            Mode = enMode.UpdateInfo;

        }

        public static DataTable GetAllCategories()
        {
            return clsCategoryBackEnd.GetAllCategories();
        }

        public static clsCategory FindCategoryByID(int ID)
        {
            string Name = "", Description = "";
            if (clsCategoryBackEnd.FindCategoryByID( ID, out Name, out Description))
            {
                return new clsCategory(ID, Name, Description);
            }
            return null;
        }

        public static clsCategory FindCategoryByName(string Name)
        {
            string Description = "";
            int ID = 0;

            if (clsCategoryBackEnd.FindCategoryByName(ref ID, ref Name, ref Description))
            {
                return new clsCategory(Name, Description);
            }
            return null;
        }

        public static DataTable SearchCategoryUsingLikeByName(string Name)
        {
            return clsCategoryBackEnd.SearchCategoryUsingLikeByName(Name);
        }

        public static int GetCategoryIDByName(string Name)
        {
            return clsCategoryBackEnd.GetCategoryIDByName(Name);
        }

        public static string GetCategoryNameByID(int ID)
        {
            string Name = clsCategoryBackEnd.GetCategoryNameByID(ID);
            if (Name != "")
                return Name;
            return "";
        }

        private bool _AddNewCategory()
        {
            return clsCategoryBackEnd.AddNewCategory(Name, Description);
        }

        private bool _UpdateCategory()
        {
            return clsCategoryBackEnd.UpdateCategory(Id, Name, Description);
        }

        public static bool DeleteCategory(int ID)
        {
            return clsCategoryBackEnd.DeleteCategory(ID);
        }

        public static bool CategoryIsExistByID(int ID)
        {
            return clsCategoryBackEnd.CategoryIsExistByID(ID);
        }

        public static int GetCountCategories()
        {
            return clsCategoryBackEnd.GetCountCategories();
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if(_AddNewCategory())
                            return true;
                        else
                            return false;


                case enMode.UpdateInfo:
                    if (_UpdateCategory())
                        return true;
                    else
                        return false;

                default:

                    return false;
            }
            return false;
        }
    }
}
