using System;
using System.Text.RegularExpressions;

namespace SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^[^||^$|^%|^.]*\%(?<name>[A-Z]{1}[a-z]+)\%[^||^$|^%|^.]*\<(?<product>[\w]+)\>[^||^$|^%|^.]*\|(?<count>\d+)\|[^||^$|^%|^.|^\d]*(?<price>\d+.?\d*)\$[^||^$|^%|^.]*$";
            string input;

            Regex regex = new Regex(pattern);

            double total = 0.0;

            while ((input = Console.ReadLine()) != "end of shift")
            {
                Match match = regex.Match(input);
                if (match.Success)
                {
                    string customerName = match.Groups["name"].Value;
                    string product = match.Groups["product"].Value;
                    double price = double.Parse(match.Groups["price"].Value);
                    int count = int.Parse(match.Groups["count"].Value);
                    double totalPrice = price * count;
                    total += totalPrice;
                    Console.WriteLine($"{customerName}: {product} - {totalPrice:f2}");
                }
            }
            Console.WriteLine($"Total income: {total:f2}");

        }
    }
}
