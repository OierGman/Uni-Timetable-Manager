using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TmLms.TM
{
    public class Course
    {
        int lvlfour;
        int lvlfive;
        int lvlsix;
        /*
        public string Code { get; set; }
        public string Name { get; set; }
        public object CourseDirector { get; set; }
        public List<object> CoreCourseList { get; set; }
        public List<object> OptionalCourseList { get; set; }

        public Course(string code, string name, object courseDirector)
        {
            Code = code;
            Name = name;    
            CourseDirector = courseDirector;
            CoreCourseList = new List<object>();
            OptionalCourseList = new List<object>();
        }
        */
        /// <summary>
        /// Adds a module to the course. It checks if the moudle can be added or not.
        /// </summary>
        /// <param name="moduleToAdd">The module to add</param>
        /// <param name="isCore">True if the moudle is core, else false if optional</param>
        /// <returns>True if succesfully added, False if not</returns>
        public bool AddModule(Module moduleToAdd, bool isCore)
        {
            if (isCore == false)
            {
                switch ((int)moduleToAdd.Level)
                {
                    case 4:
                        if (lvlfour + (int)moduleToAdd.Credits > 120 || (int)moduleToAdd.Credits > 20)
                        {
                            return false;
                        }
                        lvlfour += (int)moduleToAdd.Credits;
                        break;
                    case 5:
                        if (lvlfive + (int)moduleToAdd.Credits > 120 || (int)moduleToAdd.Credits > 40)
                        {
                            return false;
                        }
                        lvlfive += (int)moduleToAdd.Credits;
                        break;
                    default:
                        if (lvlsix + (int)moduleToAdd.Credits > 100)
                        {
                            return false;
                        }
                        lvlsix += (int)moduleToAdd.Credits;
                        break;
                }
            }
            else
            {
                switch ((int)moduleToAdd.Level)
                {
                    case 4:
                        if (lvlfour + (int)moduleToAdd.Credits > 120)
                        {
                            return false;
                        }
                        lvlfour += (int)moduleToAdd.Credits;
                        break;
                    case 5:
                        if (lvlfive + (int)moduleToAdd.Credits > 120)
                        {
                            return false;
                        }
                        lvlfive += (int)moduleToAdd.Credits;
                        break;
                    default:
                        if (lvlsix + (int)moduleToAdd.Credits > 120)
                        {
                            return false;
                        }
                        lvlsix += (int)moduleToAdd.Credits;
                        break;
                }
            }
            return true;
        }

        public void DeleteModule()
        {

        }


    }
}
