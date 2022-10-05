using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaker
{
    internal class DataInterface
    {       
        public static List<ObjectClass.Quizcard> CreateQuestion(List<ObjectClass.Quizcard> QuizCardRepository)
        {
            ObjectClass.Quizcard newQuizCard = new ObjectClass.Quizcard();

            newQuizCard.question = UserInterface.AskForQuestion();

            newQuizCard.quizCards.Add(newQuizCard);

            newQuizCard.rigthAnswer = UserInterface.AskForRightAnswer();

            newQuizCard.quizCards.Add(newQuizCard);

            int maxWrongAnswers = 2;

            while (maxWrongAnswers <= 2)
            {
                newQuizCard.wrongAnswer = UserInterface.AskForWrongAnswer();
                newQuizCard.quizCards.Add(newQuizCard);
                maxWrongAnswers++;
            }
       
            QuizCardRepository.Add(newQuizCard);

            return QuizCardRepository;
        }

        public static ObjectClass.Quizcard[] CreateGame(List<ObjectClass.Quizcard> QuizcardRepository)
        {
            ObjectClass.Quizcard[] gameQuestions = new ObjectClass.Quizcard[5];
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
