namespace QuizMaker
{
    internal class DataInterface
    {
        /// <summary>
        /// creates a new question object
        /// </summary>
        /// <param name="QuizCardRepository">List with all stored questions</param>
        /// <param name="MAX_WRONG_QUESTION_ANSWERS">number of max wrong answers for each question</param>
        /// <returns>updated List with all stored questions</returns>
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
        /// <summary>
        /// creates a List with qestions for the current game
        /// </summary>
        /// <param name="QuizcardRepository">List with all stored questions</param>
        /// <param name="MAX_GAME_QUESTIONS">number of max game questions for the current game</param>
        /// <returns></returns>
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
