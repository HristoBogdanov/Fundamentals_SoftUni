using System;
using System.Collections.Generic;
using System.Linq;

namespace Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string input = Console.ReadLine();
            while(input!="end")
            {
                var pom = input.Split(" ");
                if (pom[0] == "Delete")
                {
                    int removedNumber = int.Parse(pom[1]);
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] == removedNumber) numbers.Remove(numbers[i]);
                    }
                }
                else if (pom[0] == "Insert")
                {
                    int insertedElement = int.Parse(pom[1]);
                    int insertIndex = int.Parse(pom[2]);
                    numbers.Insert(insertIndex, insertedElement);
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
