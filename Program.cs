namespace QuizMaker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<QuizCard> quizcardRepository = new List<QuizCard>();
            
            UserInterface.GameIntroMessage();

            int createOrPlay = UserInterface.CreateOrPlayMessage();

            if(createOrPlay == 2)
            {
                bool createQuizcards = true;

                while (createQuizcards == true)
                {
                    quizcardRepository = BackUp.GetRepositoryBackup(quizcardRepository);
                    DataInterface.CreateQuestion(quizcardRepository);
                    BackUp.CreateRepositoryBackup(quizcardRepository);
                    createQuizcards = UserInterface.CreateOneMoreQuizcard();
                }
            }

            QuizCard [] gameQuestions = DataInterface.CreateGame(quizcardRepository);

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