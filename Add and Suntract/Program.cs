using System;

namespace Add_and_Suntract
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine(Subtract(Add(a,b),c));
        }
        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Subtract(int sum, int c)
        {
            return sum - c;
        }
    }
}
