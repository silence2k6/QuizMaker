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
            Console.Write("If you want to play press(1), if you want to create new questions press(2)\t");
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

        public static bool CreateOneMoreQuizcard()
        {
            bool createOneMoreQuiscard = true;
            
            Console.WriteLine("If you want to create one more question press 'Y':\t");

            string userInput = Console.ReadLine().ToUpper();

            if (userInput != "Y")
            {
                createOneMoreQuiscard = false;
            }
            return createOneMoreQuiscard;            
        }

        public static void ShowGameQuestion (ObjectClass.Quizcard[] gameQuestions)
        {
            int x = 0;

            Console.WriteLine($"{gameQuestions[x]}");
            x++;
        }

        public static int AskForAnswer()
        {
            int userAnswer = 0;
            bool validInput = false;

            while (validInput == false)
            {
                Console.WriteLine("Choose (1), (2) or (3) for your answer:\t");
                validInput = int.TryParse(Console.ReadLine(), out userAnswer);

                if (userAnswer <= 0 || userAnswer > 3)
                {
                    Console.WriteLine("Only answers between 1-3 are aviable!!!");
                    validInput = false;
                }
            }
            return userAnswer;
        }
    }
}
