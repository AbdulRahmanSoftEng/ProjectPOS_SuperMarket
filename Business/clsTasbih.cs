using BackEnd;
using System;
using System.Collections.Generic;
using System.Data;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class clsTasbih
    {
        public enum enMode { Add, Update}

        public enMode Mode;
        public int ID { get; set; }
        public string Name { get; set; }
        public byte Bred { get; set; }
        public byte Bgreen { get; set; }
        public byte Bblue { get; set; }
        public byte Fred { get; set; }
        public byte Fgreen { get; set; }
        public byte Fblue { get; set; }

        public clsTasbih()
        {
            this.Name = "";
            this.Bred = 0;
            this.Bgreen = 0;
            this.Bblue = 0;
            this.Fred = 0;
            this.Fgreen = 0;
            this.Fblue = 0;

            Mode = enMode.Add;
        }

        public clsTasbih(string name, byte bred, byte bgreen, byte bblue, byte fred, byte fgreen, byte fblue)
        {
            this.Name = name;
            this.Bred = bred;
            this.Bgreen = bgreen;
            this.Bblue = bblue;
            this.Fred = fred;
            this.Fgreen = fgreen;
            this.Fblue = fblue;

            Mode = enMode.Update;
        }
            
        public clsTasbih(int ID, string name, byte bred, byte bgreen, byte bblue, byte fred, byte fgreen, byte fblue)
        {
            this.ID = ID;
            this.Name = name;
            this.Bred = bred;
            this.Bgreen = bgreen;
            this.Bblue = bblue;
            this.Fred = fred;
            this.Fgreen = fgreen;
            this.Fblue = fblue;

            Mode = enMode.Update;
        }

        public static DataTable GetAllTasbihs()
        {
            return clsTasbihBackEnd.GetAllTasbih();
        } 
        
        public static DataTable FindTasbihByNameUsingLike(string Name)
        {
            return clsTasbihBackEnd.FindTasbihByNameUsingLike(Name);
        }

        public static clsTasbih GetTasbih()
        {
            string Name = "";
            byte Bred = 0;
            byte Bgreen = 0;
            byte Bblue = 0;
            byte Fred = 0;
            byte Fgreen = 0;
            byte Fblue = 0;

            if (clsTasbihBackEnd.GetTasbih(ref Name, ref Bred, ref Bgreen, ref Bblue, ref Fred, ref Fgreen, ref Fblue))
            {
                return new clsTasbih(Name, Bred, Bgreen, Bblue, Fred, Fgreen, Fblue);
            }
            return null;
        }

        public static clsTasbih FindTasbihByID(int ID)
        {
            string Name = "";
            byte Bred = 0;
            byte Bgreen = 0;
            byte Bblue = 0;
            byte Fred = 0;
            byte Fgreen = 0;
            byte Fblue = 0;

            if (clsTasbihBackEnd.FindTasbihByID(ID, ref Name, ref Bred, ref Bgreen, ref Bblue, ref Fred, ref Fgreen, ref Fblue))
            {
                return new clsTasbih(ID, Name, Bred, Bgreen, Bblue, Fred, Fgreen, Fblue);
            }
            return null;
        }

        public bool AddNew()
        {
            return clsTasbihBackEnd.AddNew(Name, Bred, Bgreen, Bblue, Fred, Fgreen, Fblue);
        }

        public bool Update()
        {
            return clsTasbihBackEnd.Update(ID, Name, Bred, Bgreen, Bblue, Fred, Fgreen, Fblue);
        }

        public static bool IsExistTasbih(int ID)
        {
            return clsTasbihBackEnd.IsExistTasbih(ID);
        }
        
        public static bool IsExistTasbihByName(string Name)
        {
            return clsTasbihBackEnd.IsExistTasbihByName(Name);
        } 
        
        public static bool Delete(int ID)
        {
            return clsTasbihBackEnd.Delete(ID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.Add:
                    {
                        return AddNew();
                    }


                case enMode.Update:
                    {
                        return Update();
                    }

                default:
                    return false;
            }

            return false;   
        }
    }
}
