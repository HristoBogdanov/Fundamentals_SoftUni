using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Car : IVehicle
    {

        public double FuelQuantity;
        public double FuelConsumption;
        public double TankCapacity;
        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
            TankCapacity = tankCapacity;
        }

        public string Drive(double distance)
        {
            if (FuelQuantity >= distance * (FuelConsumption + 0.9))
            {
                FuelQuantity -= distance * (FuelConsumption + 0.9);
                return $"{this.GetType().Name} travelled {distance} km";
            }
            return $"{this.GetType().Name} needs refueling";
        }

        public void Refuel(double liters)
        {
            if(liters<=0)
            {
                Console.WriteLine("Fuel must be a positive number");
                return;
            }

            if(FuelQuantity+liters>TankCapacity)
            {
                Console.WriteLine($"Cannot fit {liters} fuel in the tank");
            }
            else
            {
                FuelQuantity += liters;
            }
        }

        public string Print()
        {
            if(FuelQuantity<0)
            {
                FuelQuantity = 0;
            }
            return $"Car: {FuelQuantity:f2}";
        }
    }
}
