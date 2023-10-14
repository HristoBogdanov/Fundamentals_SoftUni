using System;

namespace Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b= double.Parse(Console.ReadLine());

            Divide(FindFactorial(a), FindFactorial(b));
        }
        static double FindFactorial(double input)
        {
            double sum = 1;
            for (int i = 1; i <= input; i++)
            {
                sum *= i;
            }
            return sum;
        }
        static void Divide(double a, double b)
        {
            Console.WriteLine($"{a/b:f2}");
        }
    }
}
