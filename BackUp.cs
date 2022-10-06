using System.Xml.Serialization;

namespace QuizMaker
{
    public class BackUp
    {            
        public static void CreateRepositoryBackup(List<QuizCard> quizCardRepository)
        {
            XmlSerializer writer = new XmlSerializer(typeof(List<QuizCard>));

            string path = @"C:\Users\user\source\repos\QuizMaker\QuizCardRepository.xml";

            using (FileStream file = File.Create(path))
            {
                writer.Serialize(file, quizCardRepository);
            }

        }
        public static List<QuizCard> GetRepositoryBackup(List<QuizCard> quizCardRepository)
        {
            XmlSerializer reader = new XmlSerializer(typeof(List<QuizCard>));

            string path = @"C:\Users\user\source\repos\QuizMaker\QuizCardRepository.xml";

            using (FileStream file = File.OpenRead(path))
            {
                quizCardRepository = reader.Deserialize(file) as List<QuizCard>;
            }
            return quizCardRepository;

        }

    }
}
