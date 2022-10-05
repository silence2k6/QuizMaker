using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaker
{
    internal class ObjectClass
    {
        public class Quizcard
        {
            public List<Quizcard> quizCards = new List<Quizcard>();
            public string question;
            public string rigthAnswer;
            public string wrongAnswer;

            public override string ToString()
            {
                return $"{question}";
            }
        }
    }
}
