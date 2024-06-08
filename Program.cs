namespace ConsoleApp30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mat1 = {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };
            int[,] mat2 = {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };
            Class1 cl1 = new Class1();
            Task3 ts3 = new Task3();
            Task4 ts4 = new Task4();
            Task5 ts5 = new Task5();
            Task6 ts6 = new Task6();
            Task7 ts7 = new Task7();
            int whil = 0;
            while (whil <= 0)
            {
                Console.WriteLine("\nChoose Task 1-7 or 8 to exit: ");
                int swh = int.Parse(Console.ReadLine());
                switch (swh)
                {
                    case 1:
                        Console.WriteLine("\nTask 1: ");
                        cl1.FirstArray();
                        Console.WriteLine("\nTask 2: ");
                        cl1.SecondArray();
                        break;
                    case 2:
                        Console.WriteLine("\nTask 3: ");
                        ts3.Task();
                        break;
                    case 3:

                        break;
                    case 4:
                        int whil2 = 0;
                        while (whil2 <= 0)
                        {
                            Console.WriteLine("\nChoose Task 1-3 or 4 to exit: ");
                            int swh2 = int.Parse(Console.ReadLine());
                            switch (swh2)
                            {
                                case 1:
                                    ts4.AddMat(mat1, mat2);
                                    break;
                                case 2:
                                    ts4.MultMat(mat1, 5);
                                    break;
                                case 3:
                                    ts4.MultiplyMat(mat1, mat2);
                                    break;
                                case 4:
                                    whil2 = 1;
                                    break;
                            }
                        }
                        break;
                    case 5:
                        Console.WriteLine("\nTask 5: ");
                        ts5.Task();
                        break;
                    case 6:
                        Console.WriteLine("\nTask 6: ");
                        ts6.Task();
                        break;
                    case 7:
                        Console.WriteLine("\nTask 7: ");
                        ts7.Task();
                        break;
                    case 8:
                        whil = 1;
                        break;

                }
            }
        }
    }
}
