using System.Xml.Serialization;

namespace QuizMaker
{
    public class BackUp
    {            
        public static void CreateRepositoryBackup(List<QuizCard> quizCardRepository, XmlSerializer writer, string path)
        {
            using (FileStream file = File.Create(path))
            {
                writer.Serialize(file, quizCardRepository);
            }
        }
        public static List<QuizCard> GetRepositoryBackup(List<QuizCard> quizCardRepository, XmlSerializer reader, string path)
        {
            using (FileStream file = File.OpenRead(path))
            {
                quizCardRepository = reader.Deserialize(file) as List<QuizCard>;
            }
            return quizCardRepository;

        }

    }
}
