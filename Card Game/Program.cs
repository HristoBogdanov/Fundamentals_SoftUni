using System;
using System.Linq;
using System.Collections.Generic;

namespace Card_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> handOne = Console
                 .ReadLine()
                 .Split(" ")
                 .Select(int.Parse)
                 .ToList();

            List<int> handTwo = Console
                 .ReadLine()
                 .Split(" ")
                 .Select(int.Parse)
                 .ToList();


            int firstPlayerCard = 0;
            int secondPlayerCard = 0;
            int sumCards = 0;
            int indexOne = 0;
            int indexTwo = 0;
            while(handOne.Count!=0 && handTwo.Count!=0)
            {
                firstPlayerCard = handOne[indexOne];
                secondPlayerCard = handTwo[indexTwo];
                if (firstPlayerCard > secondPlayerCard)
                {
                    handTwo.Remove(secondPlayerCard);
                    handOne.Remove(firstPlayerCard);
                    handOne.Add(secondPlayerCard);
                    handOne.Add(firstPlayerCard);
                }
                else if (secondPlayerCard > firstPlayerCard)
                {
                    handOne.Remove(firstPlayerCard);
                    handTwo.Remove(secondPlayerCard);
                    handTwo.Add(firstPlayerCard);
                    handTwo.Add(secondPlayerCard);
                }
                else
                {
                    handOne.Remove(firstPlayerCard);
                    handTwo.Remove(secondPlayerCard);
                }
            }

            if (handOne.Count == 0)
            {
                sumCards = handTwo.Sum();
                Console.WriteLine($"Second player wins! Sum: {sumCards}");
            }
            else
            {
                sumCards = handOne.Sum();
                Console.WriteLine($"First player wins! Sum: {sumCards}");
            }
        }
        
    }
}
