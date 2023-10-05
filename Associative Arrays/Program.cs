using System;
using System.Collections.Generic;

namespace Associative_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<char, int> characters = new Dictionary<char, int>();

            foreach (char ch in input)
            {
                if (ch != ' ')
                    { 
                    if (!characters.ContainsKey(ch))
                    {
                        characters.Add(ch, 0);
                    }
                    characters[ch]++;
                }
            }
            foreach (var kvp in characters)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
