using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaker
{
    internal class DataInterface
    {
        public class Question
        {
            public string userQuestion;
            public string rigthAnswer;
            public string wrongAnswer;
            public string anotherWrongAnswer;

        }

        public static List<string> CreateQuestion(List<string> QuestionRepository)
        {
            Question question = new Question();

            question.userQuestion = UserInterface.AskForQuestion();
            QuestionRepository.Add(question.userQuestion);

            question.rigthAnswer = UserInterface.AskForRightAnswer();
            QuestionRepository.Add(question.rigthAnswer);

            question.wrongAnswer = UserInterface.AskForWrongAnswer();
            QuestionRepository.Add(question.wrongAnswer);

            question.anotherWrongAnswer = UserInterface.AskForAnotherWrongAnswer();
            QuestionRepository.Add(question.anotherWrongAnswer);

            return QuestionRepository;
        }

        public static string CreateGameQuestions(List<string> QuestionRepository)
        {
            string[] gameQuestions = new string[10];
            int x = 0; ;

            while (x < 10)
            {
                Random randomQuestion = new Random();
                int repositoryQuestionIndex = randomQuestion.Next(QuestionRepository.Count);

                if (repositoryQuestionIndex % 4 == 0 || repositoryQuestionIndex == 0)
                {
                    gameQuestions[x] = Convert.ToString(repositoryQuestionIndex);
                    x++;
                }
                else
                {
                    continue;
                }
            }
            return Convert.ToString(gameQuestions);
        }

    }

}
