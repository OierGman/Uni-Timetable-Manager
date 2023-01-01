using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TmLms.Users
{
    public class Student : Person
    {
        /// <summary>
        /// key = module code, value = result in %
        /// </summary>
        public Dictionary<string, string> results = new Dictionary<string, string>();

        public static List<Student> students = new List<Student>();

        public Student(string name, string userID) : base(name, userID)
        {

        }
    }
}
