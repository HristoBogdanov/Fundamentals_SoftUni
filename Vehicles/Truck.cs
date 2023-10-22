using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Truck : IVehicle
    {
        public double FuelQuantity;
        public double FuelConsumption;
        public double TankCapacity;

        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
            TankCapacity = tankCapacity;
        }

        public string Drive(double distance)
        {
            if (FuelQuantity>=distance * (FuelConsumption + 1.6))
            {
                FuelQuantity -= distance * (FuelConsumption + 1.6);
                return $"{this.GetType().Name} travelled {distance} km";
            }
            return $"{this.GetType().Name} needs refueling";
        }

        public void Refuel(double liters)
        {
            if (liters <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
                return;
            }

            if (FuelQuantity + liters > TankCapacity)
            {
                Console.WriteLine($"Cannot fit {liters} fuel in the tank");
            }
            else
            {
                FuelQuantity += 0.95*liters;
            }
        }

        public string Print()
        {
            if (FuelQuantity < 0)
            {
                FuelQuantity = 0;
            }
            return $"Truck: {FuelQuantity:f2}";
        }
    }
}
