using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaker
{
    internal class UserInterface
    {
        public static void GameIntroMessage()
        {
            Console.WriteLine("Welcome to QuizMaker");
        }
        public static int CreateOrPlayMessage()
        {
            Console.WriteLine("If you want to play press(1), if you want to create new questions press(2)");
            int createOrPlay = Convert.ToInt32(Console.ReadLine());

            return createOrPlay;
        }

        public static string AskForQuestion()
        {
            Console.WriteLine("Pls give me any question:");
            string question = Console.ReadLine();
            return question;
        }

        public static string AskForRightAnswer()
        {
            Console.WriteLine("Pls put in the right answer");
            string rightAnswer = Console.ReadLine();
            return rightAnswer;
        }

        public static string AskForWrongAnswer()
        {
            Console.WriteLine("Pls put in a wrong answer");
            string wrongAnswer = Console.ReadLine();
            return wrongAnswer;
        }

        public static string AskForAnotherWrongAnswer()
        {
            Console.WriteLine("Pls put in another wrong answer");
            string anotherWrongAnswer = Console.ReadLine();
            return anotherWrongAnswer;
        }
    }
}
