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
        //public static List<string> CreateQuestions()
        //{

        //}
    }
}
