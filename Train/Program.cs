using System;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] wagons = new int[n];
            int sum = 0;
            int a = 0;
            for (int i = 0; i < n; i++)
            {
                a = int.Parse(Console.ReadLine());
                wagons[i] = a;
                sum += a;
            }
            string result = "";
            foreach (int x in wagons) result+=$"{x} ";
            Console.WriteLine(result);
            Console.WriteLine(sum);
        }
    }
}
