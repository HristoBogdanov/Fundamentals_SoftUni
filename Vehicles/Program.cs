using System;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] carTokens = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] truckTokens = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int numberOfCommands = int.Parse(Console.ReadLine());

            IVehicle car = new Car(double.Parse(carTokens[1]), double.Parse(carTokens[2]), double.Parse(carTokens[3]));
            IVehicle truck = new Truck(double.Parse(truckTokens[1]), double.Parse(truckTokens[2]), double.Parse(carTokens[3]));

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] commands = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string cmdName = commands[0];
                string vehicleType = commands[1];
                double ammount = double.Parse(commands[2]);

                if (cmdName == "Drive")
                { 
                    if(vehicleType=="Car")
                    {
                        Console.WriteLine(car.Drive(ammount)); 
                    }
                    else
                    {
                        Console.WriteLine(truck.Drive(ammount)); 
                    }
                }
                else
                {
                    if (vehicleType == "Car")
                    {
                        car.Refuel(ammount);
                    }
                    else
                    {
                        truck.Refuel(ammount);
                    }
                }
            }
            Console.WriteLine(car.Print());
            Console.WriteLine(truck.Print());
        }
    }
}
