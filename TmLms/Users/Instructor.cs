using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TmLms.Users
{
    internal class Instructor : Person
    {
        public static List<Instructor> instructors = new List<Instructor>();
        public Instructor(string name, string userID) : base(name, userID)
        {

        }
    }
}
