namespace QuizMaker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ObjectClass.Quizcard> quizcardRepository = new List<ObjectClass.Quizcard>();
            
            UserInterface.GameIntroMessage();

            int createOrPlay = UserInterface.CreateOrPlayMessage();

            if(createOrPlay == 2)
            {
                bool createQuizcards = true;

                while (createQuizcards == true)
                {
                    DataInterface.CreateQuestion(quizcardRepository);
                    createQuizcards = UserInterface.CreateOneMoreQuizcard();
                }
            }

            ObjectClass.Quizcard [] gameQuestions = DataInterface.CreateGame(quizcardRepository);

            int x = 0;

            while (x <= gameQuestions.Length)
            {
                UserInterface.ShowGameQuestion(gameQuestions);

                UserInterface.AskForAnswer();
                x++;
            }
        }
    }
}