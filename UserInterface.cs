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
            int createOrPlay = 0;
            bool validInput = false;

            while (validInput == false)
            {
                Console.Write("If you want to play press(1), if you want to create new questions press(2)\t");
                validInput = int.TryParse(Console.ReadLine(), out createOrPlay);

                if (createOrPlay <= 0 || createOrPlay > 2)
                {
                    Console.WriteLine("You can only play the game(1) or create a new question(2)");
                    validInput = false;
                }
            }
            return createOrPlay;
        }

        public static string AskForQuestion()
        {
            Console.WriteLine("Pls give me any question");
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

        public static void ShowGameQuestion (QuizCard[] gameQuestions)
        {
            int x = 0;

            QuizCard onlyQuestion = gameQuestions[x];

            Console.WriteLine(onlyQuestion.question);

            Random answerRotation = new Random();

            for (int i = 0; i < onlyQuestion.wrongAnswers.Count; i++)
            {
                int j = answerRotation.Next(i, onlyQuestion.wrongAnswers.Count);
                onlyQuestion.wrongAnswer = onlyQuestion.wrongAnswers[i];
                onlyQuestion.wrongAnswers[i] = onlyQuestion.wrongAnswers[j];
                onlyQuestion.wrongAnswers[j] = onlyQuestion.wrongAnswer;
            }
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
