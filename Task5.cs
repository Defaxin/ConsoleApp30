

namespace ConsoleApp30
{
    internal class Task5
    {
        static int Opert(int result, int number, char operation)
        {
            return operation == '+' ? result + number : result - number;
        }
        public void Task()
        {
            Console.WriteLine("Input: ");
            string input = Console.ReadLine();
            int result = 0;
            int number = 0;
            char operation = '+';
            foreach (char symbol in input)
            {
                if (char.IsDigit(symbol))
                {
                    number = number * 10 + (symbol - '0');
                }
                else if (symbol == '+' || symbol == '-')
                {
                    result = Opert(result, number, operation);
                    operation = symbol;
                    number = 0;
                }
            }
            result = Opert(result, number, operation);
            Console.WriteLine($"Result: {result}");
        }
    }
}
