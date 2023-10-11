using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Operations
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

            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] pom = input.Split(" ");
                string operation = pom[0];

                switch (operation)
                {
                    case "Add":
                        int valueAdd = int.Parse(pom[1]);
                        numbers.Add(valueAdd);
                        break;
                    case "Insert":
                        int valueInsert = int.Parse(pom[1]);
                        int indexInsert = int.Parse(pom[2]);
                        if (indexInsert < numbers.Count && indexInsert>=0)
                        {
                            numbers.Insert(indexInsert, valueInsert);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;
                    case "Remove":
                        int indexRemove = int.Parse(pom[1]);
                        if (indexRemove < numbers.Count && indexRemove>=0)
                        {
                            numbers.RemoveAt(indexRemove);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;
                    case "Shift":
                        int count = int.Parse(pom[2]);

                        if (pom[1] == "left")
                        {
                            for (int j = 0; j < count; j++)
                            { 
                                int firstElement = numbers[0];
                                for (int i = 1; i < numbers.Count; i++)
                                {
                                    numbers[i - 1] = numbers[i];
                                }
                                numbers[numbers.Count-1] = firstElement;
                            }
                        }
                        else if (pom[1] == "right")
                        {
                            for (int j = 0; j < count; j++)
                            {
                                int lastElement = numbers[numbers.Count - 1];

                                for (int i = numbers.Count - 1; i > 0; i--)
                                {
                                    numbers[i] = numbers[i - 1];
                                }
                                numbers[0] = lastElement;
                            }
                        }
                        break;
                }
                input = Console.ReadLine();
            }
            foreach (int x in numbers)
            {
                Console.Write($"{x} ");
            }
        }
    }
}
