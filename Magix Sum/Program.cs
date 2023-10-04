using System;
using System.Linq;
using System.Collections.Generic;

namespace Magix_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sum = int.Parse(Console.ReadLine());
            Dictionary<int, int> elements = new Dictionary<int, int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (i != j && numbers[i] + numbers[j] == sum)
                    {
                        if (!elements.ContainsKey(numbers[j]) && !elements.ContainsValue(numbers[j]))
                        {
                            elements.Add(numbers[i], numbers[j]);
                        }
                    }
                }
                
            }
            foreach (var x in elements)
            {
                Console.WriteLine($"{x.Key} {x.Value}");
            }
        }
        }
    }

