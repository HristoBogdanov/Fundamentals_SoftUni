using System;
using System.Text.RegularExpressions;

namespace First_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^\|(?<name>[A-Z]{4,})\|:#(?<title>[A-Za-z]+ [A-Za-z]+)#$";
            Regex regex = new Regex(pattern);

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();
                Match match = regex.Match(input);

                if(match.Success)
                {
                    string nameBoss = match.Groups["name"].Value;
                    string title = match.Groups["title"].Value;

                    int strength = nameBoss.Length;
                    int armor = title.Length;

                    Console.WriteLine($"{nameBoss}, The {title}");
                    Console.WriteLine($">> Strength: {strength}");
                    Console.WriteLine($">> Armor: {armor}");
                }
                else
                {
                    Console.WriteLine("Access denied!");
                }
            }
        }
    }
}
