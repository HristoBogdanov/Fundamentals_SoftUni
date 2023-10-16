using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory_Ga_e
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine()
                .Split(' ')
                .ToList();

            int numberMoves = 0;

            string input = Console.ReadLine();

            while (input != "end")
            {
                int[] indexes = input
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

                numberMoves++;

                int indexOne = indexes[0];
                int indexTwo = indexes[1];

                if (indexOne == indexTwo)
                {
                    elements.Insert((elements.Count / 2), $"-{numberMoves}a");
                    elements.Insert((elements.Count / 2), $"-{numberMoves}a");
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }
                else if (indexOne < 0 || indexOne >= elements.Count)
                {
                    elements.Insert((elements.Count / 2), $"-{numberMoves}a");
                    elements.Insert((elements.Count / 2), $"-{numberMoves}a");
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }
                else if (indexTwo < 0 || indexTwo >= elements.Count)
                {
                    elements.Insert((elements.Count / 2), $"-{numberMoves}a");
                    elements.Insert((elements.Count / 2), $"-{numberMoves}a");
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }
                else
                {
                    if (elements[indexOne] == elements[indexTwo])
                    {
                        Console.WriteLine($"Congrats! You have found matching elements - {elements[indexOne]}!");
                        if (indexOne < indexTwo)
                        {
                            elements.RemoveAt(indexOne);
                            elements.RemoveAt(indexTwo - 1);
                        }
                        else 
                        {
                            elements.RemoveAt(indexTwo);
                            elements.RemoveAt(indexOne - 1);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Try again!");
                    }
                }

                if (elements.Count == 0)
                {
                    Console.WriteLine($"You have won in {numberMoves} turns!");
                    break;
                }
                input = Console.ReadLine();
            }
            if (elements.Count > 0)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(" ",elements));
            }
        }
    }
}
