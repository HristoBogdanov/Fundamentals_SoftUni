using System;

namespace MxM_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            PrintMatrix(input);
        }
        static void PrintMatrix(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{n} ");
                }
                Console.WriteLine();
            }
        }
    }
     
}
