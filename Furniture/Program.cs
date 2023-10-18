using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^>>(?<name>[A-Z][A-Za-z]+)<<(?<price>\d+.?\d*)!(?<quantity>\d+)(.?\d*)$";
            Regex regex = new Regex(pattern);
            List<string> furniture = new List<string>();

            double totalPrice = 0.0;

            string input;
            while ((input = Console.ReadLine()) != "Purchase")
            {
                Match match = regex.Match(input);
                if (match.Success)
                {
                    furniture.Add(match.Groups["name"].Value);
                    double price = double.Parse(match.Groups["price"].Value);
                    double quantity= double.Parse(match.Groups["quantity"].Value);

                    totalPrice += price * quantity;
                }
            }

            Console.WriteLine("Bought furniture:");
            foreach (var item in furniture)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}
