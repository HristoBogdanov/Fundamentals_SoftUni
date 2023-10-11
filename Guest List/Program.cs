using System;
using System.Collections.Generic;
using System.Linq;

namespace Guest_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guests = new List<string>();
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                var pom = Console.ReadLine().Split(" ");
                if (pom.Contains("not"))
                {
                    string removedGuest = pom[0];
                    if (guests.Contains(removedGuest))
                    {
                        guests.Remove(removedGuest);
                    }
                    else
                    {
                        Console.WriteLine($"{removedGuest} is not in the list!");
                    }
                }
                else
                {
                    string addGuest = pom[0];
                    if (guests.Contains(addGuest))
                    {
                        Console.WriteLine($"{addGuest} is already in the list!");
                    }
                    else
                    {
                        guests.Add(addGuest);
                    }
                }
            }
            foreach (string x in guests)
            { 
                Console.WriteLine(x);
            }
        }
    }
}
