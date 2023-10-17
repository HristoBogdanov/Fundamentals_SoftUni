using System;
using System.Collections.Generic;
using System.Linq;

namespace Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            List<string> wantedVehicles = new List<string>();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] arr = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string type = arr[0];
                string model = arr[1];
                string color = arr[2];
                int hoursePower = int.Parse(arr[3]);

                Vehicle vehicle = new Vehicle(type, model, color, hoursePower);
                vehicles.Add(vehicle);
            }

            string input2;
            while ((input2 = Console.ReadLine()) != "Close the Catalogue")
            {
                wantedVehicles.Add(input2);
            }

            foreach (string wantedVehicle in wantedVehicles)
            {
                foreach (Vehicle x in vehicles)
                {
                    if (x.Model == wantedVehicle)
                    {
                        Console.WriteLine(x.ToString());
                        break;
                    }
                }
            }

            double sumCars = 0;
            int countCars = 0;
            double sumTrucks = 0;
            int countTrucks = 0;

            foreach (Vehicle x in vehicles)
            {
                if (x.TypeVehicle == "car")
                {
                    sumCars += x.HoursePower;
                    countCars++;
                }
                else
                {
                    sumTrucks += x.HoursePower;
                    countTrucks++;
                }
            }
            if (countCars == 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {sumCars / countCars:f2}.");
            }
            if (countTrucks == 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {sumTrucks / countTrucks:f2}.");
            }

        }
    }

    public class Vehicle
    {
        public string TypeVehicle { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HoursePower { get; set; }

        public Vehicle(string type,string model,string color,int hoursePower)
        {
            TypeVehicle = type;
            Model = model;
            Color = color;
            HoursePower = hoursePower;
        }

        public string GetPrintType()
        {
            string result = "";
            if (this.TypeVehicle == "car")
            {
                result = "Car";
            }
            else
            {
                result = "Truck";
            }
            return result;
        }
        public override string ToString()
        {
            string result = "";
            result += $"Type: {this.GetPrintType()}\n";
            result += $"Model: {this.Model}\n";
            result += $"Color: {this.Color}\n";
            result += $"Horsepower: {this.HoursePower}";

            return result;
        }
    }
}
