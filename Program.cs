using System.Xml.Serialization;

namespace QuizMaker
{
    internal class Program
    {       
        static void Main(string[] args)
        {
            XmlSerializer writer = new XmlSerializer(typeof(List<QuizCard>));
            XmlSerializer reader = new XmlSerializer(typeof(List<QuizCard>));
            var path = @"C:\Users\user\source\repos\QuizMaker\QuizCardRepository\QuizCardRepository.xml";

            List<QuizCard> quizcardRepository = new List<QuizCard>();
            int rightAnswerCounter = 0;

            UserInterface.GameIntroMessage();

            int createOrPlay = UserInterface.CreateOrPlayMessage();

            if (createOrPlay == 2)
            {
                bool createQuizcards = true;

                while (createQuizcards == true)
                {
                    quizcardRepository = BackUp.GetRepositoryBackup(quizcardRepository, reader, path);
                    DataInterface.CreateQuestion(quizcardRepository);
                    createQuizcards = UserInterface.CreateOneMoreQuizcard();
                    BackUp.CreateRepositoryBackup(quizcardRepository, writer, path);
                }
                createOrPlay = 1;
            }

            if (createOrPlay == 1)
            {
                UserInterface.GameStartMessage();

                quizcardRepository = BackUp.GetRepositoryBackup(quizcardRepository, reader, path);
                List<QuizCard> gameQuestions = DataInterface.CreateGame(quizcardRepository);
            
                while (gameQuestions.Count > 0)
                {
                    int rightAnswer = UserInterface.ShowGameQuestion(gameQuestions[0]);
                    int userAnswer = UserInterface.ShowQuestionAnswers(gameQuestions[0]);

                    if (rightAnswer == userAnswer)
                    {
                        rightAnswerCounter++;
                    }

                    gameQuestions.RemoveAt(0);
                }
                UserInterface.resultMessage(rightAnswerCounter);
            }
        }
    }
}