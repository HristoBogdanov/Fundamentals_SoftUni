using System;

namespace Smallest_of_Three_Numbers
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(smallCalculate(a,b,c));
        }
        public static int smallCalculate(int a, int b, int c)
        {
            int result = 0;
            if (a <= b && a <= c) result = a;
            if (b <= a && b <= c) result = b;
            if (c <= a && c <= b) result = c;
            return result;
        }
    }
}
