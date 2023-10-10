using System;
using System.Collections.Generic;

namespace Strong_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            List<int> digits = new List<int>();
            int pom = a;
            while (pom != 0)
            {
                digits.Add(pom % 10);
                pom = pom / 10;
            }
            int sum = 0;
            for (int i = 0; i < digits.Count; i++)
            {
                int number = digits[i];
                int factorial = 1;
                for (int j = 1; j <=number; j++)
                {
                    factorial = factorial * j;
                }
                sum += factorial;
            }
            if (sum == a) Console.WriteLine("yes");
            else Console.WriteLine("no");
        }
    }
}
