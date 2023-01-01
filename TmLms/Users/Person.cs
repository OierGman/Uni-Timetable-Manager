using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TmLms.Users
{
    public class Person
    {
        public string name { get; set; }   
        public string userID { get; set; }

        public Person(string name, string userID)
        {
            this.name = name;
            this.userID = userID;
        }
    }
}
