

namespace ConsoleApp30
{
    internal class Task6
    {
        public string Change(string input)
        {
            char[] chars = input.ToCharArray();
            bool isFirstLetter = true;
            for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsLetter(chars[i]) && isFirstLetter)
                {
                    chars[i] = char.ToUpper(chars[i]);
                    isFirstLetter = false;
                }
                else if (chars[i] == '.' || chars[i] == '?' || chars[i] == '!')
                {
                    isFirstLetter = true;
                }
            }
            return new string(chars);
        }
        public void Task()
        {
            Console.WriteLine("Input: ");
            string input = Console.ReadLine();
            string result = Change(input);
            Console.WriteLine($"Result:\n{result}");
            Console.ReadKey();
        }
    }
}
