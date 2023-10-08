using System;

namespace Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int pom = a;
            int sum=0;
            while (pom != 0)
            {
                sum += pom % 10;
                pom = pom / 10;
            }
            Console.WriteLine(sum);

        }
    }
}
