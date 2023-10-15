using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cars = Console.ReadLine()
                .Split('>')
                .ToList();

            string carType = "";
            int years = 0;
            int kilometers = 0;
            int tax = 0;
            int totalTax = 0;

            foreach (string x in cars) Console.WriteLine(x);

            for (int i = 0; i < cars.Count; i++)
            {
                tax = 0;
                var pom = cars[i].Split(' ');

                carType = pom[0];
                years = int.Parse(pom[1]);
                kilometers = int.Parse(pom[2]);

                if (carType != "family" && carType != "heavyDuty" && carType != "sports")
                {
                    Console.WriteLine("Invalid car type.");
                    return;
                }
                else if (carType == "family")
                {
                    tax += 12 * (kilometers / 3000);
                    tax -= 5 * years;
                }
                else if (carType == "heavyDuty")
                {
                    tax += 14 * (kilometers / 9000);
                    tax -= 8 * years;
                }
                else if (carType == "sports")
                {
                    tax += 18 * (kilometers / 2000);
                    tax -= 9 * years;
                }
                totalTax += tax;
                Console.WriteLine($"A {carType} car will pay {tax:f2} euros in taxes.");
            }
            Console.WriteLine($"The National Revenue Agency will collect {totalTax} euros in taxes.");
        }
    }
}
