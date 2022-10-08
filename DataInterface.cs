namespace QuizMaker
{
    internal class DataInterface
    {
        public static List<QuizCard> CreateQuestion(List<QuizCard> QuizCardRepository, int MAX_WRONG_QUESTION_ANSWERS)
        {
            QuizCard newQuizCard = new QuizCard();

            newQuizCard.question = UserInterface.AskForQuestion();

            newQuizCard.rigthAnswer = UserInterface.AskForRightAnswer();
            newQuizCard.allAnswers.Add(newQuizCard.rigthAnswer);

            int maxWrongAnswers = MAX_WRONG_QUESTION_ANSWERS;

            while (maxWrongAnswers >= 0)
            {
                newQuizCard.allAnswers.Add(UserInterface.AskForWrongAnswer());
                maxWrongAnswers--;
            }

            QuizCardRepository.Add(newQuizCard);

            return QuizCardRepository;
        }

        public static List<QuizCard> CreateGame(List<QuizCard> QuizcardRepository, int MAX_GAME_QUESTIONS)
        {
            List<QuizCard> listOfPossibleQuestions = QuizcardRepository;
            List<QuizCard> gameQuestions = new List<QuizCard>();
            int numberOfGameQuestions = 0;

            while (numberOfGameQuestions < MAX_GAME_QUESTIONS)
            {
                Random randomQuestion = new Random();
                int repositoryQuestionIndex = randomQuestion.Next(listOfPossibleQuestions.Count);
                gameQuestions.Add(listOfPossibleQuestions[repositoryQuestionIndex]);
                listOfPossibleQuestions.RemoveAt(repositoryQuestionIndex);

                numberOfGameQuestions++;
            }
            return gameQuestions;
        }
    }
}
