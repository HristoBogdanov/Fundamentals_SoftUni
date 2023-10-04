using System;

namespace Zig_zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr1 = new int[n];
            int[] arr2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] temp = input.Split(" ");
                if (i % 2 == 0)
                {
                    arr1[i] = int.Parse(temp[0]);
                    arr2[i] = int.Parse(temp[1]);
                }
                else
                {
                    arr2[i] = int.Parse(temp[0]);
                    arr1[i] = int.Parse(temp[1]);
                }
            }
            foreach (int x in arr1) Console.Write($"{x} ");
            Console.WriteLine();
            foreach (int x in arr2) Console.Write($"{x} ");
        }
    }
}
