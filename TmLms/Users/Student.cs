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
        public Dictionary<string, TM.Marks> results = new Dictionary<string, TM.Marks>();

        public static List<Student> students = new List<Student>();

        public Student(string name, string userID) : base(name, userID)
        {

        }

        public string GetClassification(TM.Marks results)
        {
            decimal x = (Decimal)results.AchievedMark / (Decimal)results.MaxMarks;
            switch ((int)Math.Round(x * 100,0))
            {
                case >= 70:
                    return "1st";
                case >= 60:
                    return "2:1";
                case >= 50:
                    return "2:2";
                case >= 40:
                    return "3rd";
                default:
                    return "Fail";
            }
        }
    }
}
