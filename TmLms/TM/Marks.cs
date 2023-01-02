using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TmLms.TM
{
    public class Marks
    {
        public int AchievedMark { get; set; }
        public int MaxMarks { get; set; }

        public Marks(int maxMarks)
        {
            MaxMarks = maxMarks;
        }

        public string getMarks()
        {
            return AchievedMark.ToString();
        }

        public string GetPercentage()
        {
            return ((AchievedMark/MaxMarks)*100).ToString() + "%";
        }
    }
}
