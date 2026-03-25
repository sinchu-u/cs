using System.IO;

namespace task_1
{
    internal class Program
    {
        public delegate string TextOperation(string text);
        public static string uppercaseText(string text)
        {
            return text.ToUpper();
        }
        public static string lettersCount(string text)
        {
            return $"letters: {text.Length}";
        }
        public static string wordsCount(string text)
        {
            int count = 0;
            string[] lines = text.Split('\n');
            foreach (string line in lines)
            {
                for (int i = 0; i < line.Length; i++)
                {
                    if (text[i] == ' ')
                    {
                        count++;
                    }
                }
            }
                return $"words: {count}";
        }
        public static void ProcessFile(string textFile, string resultFile, TextOperation operation)
        {
            using (StreamReader sr = new StreamReader(textFile))
            {
                string line = sr.ReadToEnd();
                using (StreamWriter sw = new StreamWriter(resultFile, true))
                {
                    sw.WriteLine(operation(line));
                }
            }
        }
        static void Main(string[] args)
        {
            string textFile = "textPD21.txt";
            string resultFile = "resultPD21.txt";
            TextOperation toUpper = uppercaseText;
            TextOperation letterCount = lettersCount;
            TextOperation wordCount = wordsCount;
            ProcessFile(textFile, resultFile, toUpper);
            ProcessFile(textFile, resultFile, lettersCount);
            ProcessFile(textFile, resultFile, wordsCount);
        }
    }
}
