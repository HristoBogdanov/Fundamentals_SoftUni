using System;
using System.Collections.Generic;

namespace Third_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> guests = new Dictionary<string, List<string>>();

            string input;

            int dislikedMeals = 0;

            while ((input=Console.ReadLine())!="Stop")
            {
                string[] commands = input
                    .Split("-", StringSplitOptions.RemoveEmptyEntries);

                string cmdName = commands[0];
                string guestName = commands[1];
                string meal = commands[2];


                if (cmdName == "Like")
                {
                    if (!guests.ContainsKey(guestName))
                    {
                        guests.Add(guestName, new List<string>());
                    }
                    if (!guests[guestName].Contains(meal))
                    {
                        guests[guestName].Add(meal);
                        
                    }
                }
                else if(cmdName=="Dislike")
                {
                    if (!guests.ContainsKey(guestName))
                    {
                        Console.WriteLine($"{guestName} is not at the party.");
                    }
                    else if (!guests[guestName].Contains(meal))
                    {
                        Console.WriteLine($"{guestName} doesn't have the {meal} in his/her collection.");
                    }
                    else
                    {
                        guests[guestName].Remove(meal);
                        dislikedMeals++;
                        Console.WriteLine($"{guestName} doesn't like the {meal}.");
                    }
                }
            }
            foreach (var kvp in guests)
            {
                string guest = kvp.Key;
                string result = "";
                foreach(string meal in kvp.Value)
                {
                    result = string.Join(", ", kvp.Value);
                }
                Console.WriteLine($"{guest}: {result}");
            }
            Console.WriteLine($"Unliked meals: {dislikedMeals}");
        }
    }
}
