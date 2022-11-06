using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TmLms.Users
{
    internal class Administrator : Person
    {
        public static List<Administrator> administrators = new List<Administrator>();

        public Administrator(string name, string userID) : base(name, userID)
        {

        }

        public void CreateCourse()
        {

        }

        public void CreateModule()
        {

        }

        public void DeleteCourse()
        { 
        
        }
    }
}
