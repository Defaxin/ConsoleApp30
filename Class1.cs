

namespace ConsoleApp30
{
    internal class Class1
    {
        public void FirstArray()
        {
            int[] num = new int[5];
            int maxA = num[0];
            int minA = num[0];
            int sumA = 0;
            int productA = 1;
            int sumEvenA = 0;

            Console.WriteLine("Input: ");
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int i in num)
            {
                Console.WriteLine(i + " ");
            }

            foreach (int item in num)
            {
                if (item > maxA)
                    maxA = item;
                if (item < minA)
                    minA = item;
                sumA += item;
                productA *= item;
                if (item % 2 == 0)
                    sumEvenA += item;
            }
            Console.WriteLine(maxA + " " + minA + " " + sumA + " " + productA + " " + sumEvenA);
        }
        public void SecondArray()
        {
            double sumOddColumnsB = 0;
            double[,] B = new double[3, 4];
            Random rand = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    B[i, j] = rand.NextDouble() * 100;
                    Console.Write(B[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int j = 0; j < 4; j++)
            {
                if (j % 2 != 0)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        sumOddColumnsB += B[i, j];
                    }
                }
            }
            Console.WriteLine(sumOddColumnsB);
        }
    }
}
