using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                string result = i.ToString();
                for (int j = 2; j <= i; j++)
                {
                    result += $" {i}";
                }
                Console.WriteLine(result);
            }
        }
    }
}
