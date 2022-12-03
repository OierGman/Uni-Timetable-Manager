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
        public List<string> Correct_Ans { get; set; }
        public List<string> Incorrect_Ans { get; set; }

        /// <summary>
        /// Create a new Quiz question and store attributes. The creator of the quiz can create as many questions as
        /// they need, the creator will also set some parameters for the quiz, the user will then recieve a random 
        /// mixture of questions that match the module code based on params set by creator.
        /// </summary>
        /// <param name="moduleCode"></param>
        /// should be the module code that the quiz is assigned to 
        /// <param name="type"></param>
        /// the type of question eg. "multiple choice", "bool", "multiple ans", ect
        /// <param name="question"></param>
        /// question as string
        /// <param name="correct_Ans"></param>
        /// answers as collection
        /// <param name="incorrect_Ans"></param>
        /// incorrect answers as collection
        public Quiz(string moduleCode, string type, string question, List<string> correct_Ans, List<string> incorrect_Ans)
        {
            ModuleCode = moduleCode;
            Type = type;
            Question = question;
            Correct_Ans = correct_Ans;
            Incorrect_Ans = incorrect_Ans;
        }
    }
}
