using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TmLms
{
    internal class Quiz
    {
        public static List<Quiz> questions = new List<Quiz>();
        public string ModuleCode { get; set; }
        public string Type { get; set; }
        public string Question { get; set; }
        public string Correct_Ans { get; set; }
        public List<string> Incorrect_Ans { get; set; }

        public Quiz(string moduleCode, string type, string question, string correct_Ans, List<string> incorrect_Ans)
        {
            ModuleCode = moduleCode;
            Type = type;
            Question = question;
            Correct_Ans = correct_Ans;
            Incorrect_Ans = incorrect_Ans;
        }
    }
}
