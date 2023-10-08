using System;

namespace Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string model;
            double radius;
            int height;
            double volume = 0;
            double maxVolume = 0;
            string nameMax = "";
            for (int i = 0; i < n; i++)
            {
                model = Console.ReadLine();
                radius = double.Parse(Console.ReadLine());
                height = int.Parse(Console.ReadLine());

                volume = Math.PI * radius * radius * height;

                if (volume > maxVolume) 
                {
                    maxVolume = volume;
                    nameMax = model;
                }
            }
            Console.WriteLine(nameMax);
        }
    }
}
