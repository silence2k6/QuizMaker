using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaker
{
    public class QuizCard
    {
        public string question;
        public string rigthAnswer;
        public string wrongAnswer;

        public List<string> wrongAnswers = new List<string>();

        public override string ToString()
        {
            return $"{question}";
        }
    }
    
}
