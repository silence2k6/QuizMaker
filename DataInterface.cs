namespace QuizMaker
{
    internal class DataInterface
    {
        public static List<QuizCard> CreateQuestion(List<QuizCard> QuizCardRepository)
        {
            QuizCard newQuizCard = new QuizCard();

            newQuizCard.question = UserInterface.AskForQuestion();

            newQuizCard.rigthAnswer = UserInterface.AskForRightAnswer();
            newQuizCard.wrongAnswers.Add(newQuizCard.rigthAnswer);

            int maxWrongAnswers = 2;

            while (maxWrongAnswers >= 0)
            {
                newQuizCard.wrongAnswers.Add(UserInterface.AskForWrongAnswer());
                maxWrongAnswers--;
            }

            QuizCardRepository.Add(newQuizCard);

            return QuizCardRepository;
        }

        public static QuizCard[] CreateGame(List<QuizCard> QuizcardRepository)
        {
            QuizCard[] gameQuestions = new QuizCard[5];
            int createGameQuestionsCounter = 0;

            while (createGameQuestionsCounter < 5)
            {
                Random randomQuestion = new Random();
                int repositoryQuestionIndex = randomQuestion.Next(QuizcardRepository.Count);
                gameQuestions[createGameQuestionsCounter] = QuizcardRepository[repositoryQuestionIndex];

                //if one question object goes into the gameQuestion Array, set a marker on it, so it cant be choosen again by the random method

                createGameQuestionsCounter++;
            }
            return gameQuestions;
        }
    }
}
