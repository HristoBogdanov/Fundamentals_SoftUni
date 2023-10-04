using System;
using System.Linq;
using System.Collections.Generic;

namespace Max_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int start = 0;
            int count = 0;
            int maxElement = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    count++;
                    if (count > maxElement)
                    {
                        start = i - count;
                        maxElement = count;
                    }
                }
                else
                {
                    count = 0;
                }
            }

            for (int i = start + 1; i <= start + maxElement + 1; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
