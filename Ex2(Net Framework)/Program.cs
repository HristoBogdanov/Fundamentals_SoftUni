using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_Net_Framework_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cars = Console.ReadLine()
                .Split('>')
                .Where(s => !string.IsNullOrWhiteSpace(s))
                .ToList();

            string carType = "";
            int years = 0;
            int kilometers = 0;
            int tax = 0;
            int totalTax = 0;

            string[] car = new string[3];


            for (int i = 0; i < cars.Count; i++)
            {
                tax = 0;
                car = cars[i]
                    .Split(' ')
                    .Where(s => !string.IsNullOrWhiteSpace(s))
                    .ToArray();

                carType = car[0];
                years = int.Parse(car[1]);
                kilometers = int.Parse(car[2]);

                if (carType != "family" && carType != "heavyDuty" && carType != "sports")
                {
                    Console.WriteLine("Invalid car type.");
                    continue;
                }
                else if (carType == "family")
                {
                    tax = 50;
                    tax += 12 * (kilometers / 3000);
                    tax -= 5 * years;
                }
                else if (carType == "heavyDuty")
                {
                    tax = 80;
                    tax += 14 * (kilometers / 9000);
                    tax -= 8 * years;
                }
                else if (carType == "sports")
                {
                    tax = 100;
                    tax += 18 * (kilometers / 2000);
                    tax -= 9 * years;
                }
                totalTax += tax;
                Console.WriteLine($"A {carType} car will pay {tax:f2} euros in taxes.");
            }
            Console.WriteLine($"The National Revenue Agency will collect {totalTax:f2} euros in taxes.");
        }
    }
}
