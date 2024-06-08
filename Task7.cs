

namespace ConsoleApp30
{
    internal class Task7
    {
        public void Task()
        {
            static string Text(string text, string[] forbiddenWords, Dictionary<string, int> stats)
            {
                string[] words = text.Split(new char[] { ' ', '.', ',', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string word in words)
                {
                    if (forbiddenWords.Contains(word))
                    {
                        if (!stats.ContainsKey(word))
                        {
                            stats[word] = 0;
                        }
                        stats[word]++;

                        text = text.Replace(word, new string('*', word.Length));
                    }
                }

                return text;
            }
            Console.WriteLine("Input: ");
            string input = Console.ReadLine();
            Console.WriteLine("Input: ");
            string[] forbiddenWords = Console.ReadLine().Split(',');
            Dictionary<string, int> stats = new Dictionary<string, int>();
            string result = Text(input, forbiddenWords, stats);
            Console.WriteLine($"Resultat:\n{result}");
            Console.WriteLine("\nStat: ");
            foreach (var pair in stats)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }
    }
}
