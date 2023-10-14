using System;

namespace Top_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                if (HoldsOddDigt(i)&& IsDivisable(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        static bool IsDivisable(int number)
        {
            bool result;
            int s = 0;
            while (number != 0)
            {
                s += number % 10;
                number = number / 10;
            }
            if (s % 8 == 0)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
        static bool HoldsOddDigt(int number)
        {
            bool result=false;
            int pom = 0;
            while (number != 0)
            {
                pom = number % 10;
                if (pom % 2 != 0)
                {
                    result = true;
                    break;
                }
                number = number / 10;
            }
            return result;
        }
    }
}
