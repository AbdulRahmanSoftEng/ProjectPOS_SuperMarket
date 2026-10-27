using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using BackEnd;

namespace Business
{
    public class clsPerson
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }

        public clsPerson()
        {
            this.ID = -1;
            this.FirstName = "";
            this.LastName = "";
            this.Phone = "";
        }

        public clsPerson(int ID, string firstName, string lastName, string phone)
        {
            this.ID = ID;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Phone = phone;
        }

        public clsPerson(string firstName, string lastName, string phone)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Phone = phone;
        }
    }
}
