using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TmLms
{
    public sealed class TMEngine
    {
        public Dictionary<int,TM.Course> CourseDictionary { get; set; }

        public Dictionary<int, TM.Module> ModuleDictionary { get; set; }


        private static readonly TMEngine instance = new TMEngine();

        static TMEngine()
        {
        }

        private TMEngine()
        {
            CourseDictionary = new Dictionary<int, TM.Course>();
            ModuleDictionary = new Dictionary<int, TM.Module>();
        }

        public static TMEngine Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
