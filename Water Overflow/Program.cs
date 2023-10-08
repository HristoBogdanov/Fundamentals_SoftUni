using System;

namespace Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int capacity = 0;
            int inLiters= 0;
            for (int i = 0; i < n; i++)
            {
                inLiters = int.Parse(Console.ReadLine());
                if (inLiters>255-capacity) Console.WriteLine("Insufficient capacity!");
                else capacity += inLiters;
            }
            Console.WriteLine(capacity);
        }
    }
}
