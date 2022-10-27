using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TmLms.Users
{
    internal class Person
    {
        public string name;
        public string userID;

        public Person(string name, string userID)
        {
            this.name = name;
            this.userID = userID;
        }
    }
}
