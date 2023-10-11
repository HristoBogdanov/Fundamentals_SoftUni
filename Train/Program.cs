using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = new List<int>();

            string input = Console.ReadLine();
            wagons = input.Split(" ").Select(int.Parse).ToList();
            int capacity = int.Parse(Console.ReadLine());

            input = Console.ReadLine();


            while (input != "end")
            {
                string[] pom = input.Split(" ");
                if (pom.Length>1)
                {
                    wagons.Add(int.Parse(pom[1]));
                }
                else
                {
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        int newPassangers = int.Parse(input);
                        if (wagons[i] + newPassangers <= capacity)
                        {
                            wagons[i] += newPassangers;
                            break;
                        }
                    }
                }
                input = Console.ReadLine();
            } 

            foreach (int x in wagons)
            {
                Console.Write($"{x} ");
            }
        }
    }
}
