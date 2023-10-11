using System;
using System.Collections.Generic;
using System.Linq;

namespace Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
           List<int> numbers = Console
                .ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            int[] pom= Console
                .ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int bomb = pom[0];
            int power = pom[1];

            int totalSum = 0;
            int bombSum = 0;
            string wtf = "";

            List<int> bombIndexes = new List<int>();


            for (int i = 0; i < numbers.Count; i++)
            {
                totalSum += numbers[i];
                if (numbers[i] == bomb)
                {
                    bombIndexes.Add(i);
                }
            }
            for(int i=0;i<bombIndexes.Count-1;i++)
            {
                if(bombIndexes[i]+power>=bombIndexes[i+1])
                {
                    bombIndexes.Remove(bombIndexes[i + 1]);
                }
            }
            foreach (int x in bombIndexes)
            {
                bombSum = 0;
                int bombIndex = x;
                int brLeft = 0;
                for (int i = bombIndex-1; i >= 0; i--)
                {
                    if (brLeft < power)
                    {
                        bombSum += numbers[i];
                        brLeft++;
                        wtf += $"{numbers[i]}+";
                    }
                    else
                    {
                        break;
                    }
                }
                int brRight = 0;
                for (int j = bombIndex+1; j < numbers.Count; j++)
                {
                    if (brRight < power)
                    {
                        bombSum += numbers[j];
                        brRight++;
                        wtf += $"{numbers[j]}+";
                    }
                    else
                    {
                        break;
                    }
                }
                totalSum -= bombSum;
                totalSum -= bomb;
            }
            Console.WriteLine(totalSum);
        }
    }
}
