using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaker
{
    internal class DataInterface
    {       
        public static List<ObjectClass.Quizcard> CreateQuestion(List<ObjectClass.Quizcard> QuizcardRepository)
        {
            ObjectClass.Quizcard quizcard = new ObjectClass.Quizcard();

            quizcard.question = UserInterface.AskForQuestion();
            
            quizcard.rigthAnswer = UserInterface.AskForRightAnswer();
            
            quizcard.wrongAnswer = UserInterface.AskForWrongAnswer();

            quizcard.anotherWrongAnswer = UserInterface.AskForAnotherWrongAnswer();

            QuizcardRepository.Add(quizcard);

            return QuizcardRepository;
        }

        public static ObjectClass.Quizcard[] CreateGame(List<ObjectClass.Quizcard> QuizcardRepository)
        {
            ObjectClass.Quizcard[] gameQuestions = new ObjectClass.Quizcard[2];
            int createGameQuestionsCounter = 0;

            while (createGameQuestionsCounter < 2)
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
