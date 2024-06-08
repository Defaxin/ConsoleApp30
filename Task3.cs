

namespace ConsoleApp30
{
    internal class Task3
    {
        public void Task()
        {
            int[,] arr = new int[5, 5];
            Random rand = new Random();
            int min = -100;
            int max = 100;
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arr[i, j] = rand.Next(-100, 100);
                    Console.Write(arr[i, j] + "\t");
                    if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                    }
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                    }

                }
                Console.WriteLine();
            }
            bool MinMax = false;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (arr[i, j] == min || arr[i, j] == max)
                    {
                        if (!MinMax)
                        {
                            MinMax = true;
                        }
                        else
                        {
                            MinMax = false;
                        }
                    }
                    if (MinMax)
                    {
                        sum += arr[i, j];
                    }
                }
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
