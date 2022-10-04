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
            public string question;
            public string rigthAnswer;
            public string wrongAnswer;
            public string anotherWrongAnswer;

            public override string ToString()
            {
                return $"{question}\n1){rigthAnswer}\n2){wrongAnswer}\n3){anotherWrongAnswer}";
            }

        }
    }
}
