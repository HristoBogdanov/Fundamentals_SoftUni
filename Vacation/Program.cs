using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();

            double result = 0;

            switch (type)
            {
                case "Students":
                    if (day == "Friday")
                    {
                        if (count >= 30) result = count * 8.45 - 0.15 * (result = count * 8.45);
                        else result = count * 8.45;

                    }
                    else if(day== "Saturday")
                    {
                        if (count >= 30) result = count * 9.80 - 0.15 * (result = count * 9.80);
                        else result = count * 9.80;

                    }
                    else
                    {
                        if (count >= 30) result = count * 10.46 - 0.15 * (result = count * 10.46);
                        else result = count * 10.46;

                    }
                    break;
                case "Business":
                    if (day == "Friday")
                    {
                        if (count >= 100) result = count * 10.90 - (10 * 10.90);
                        else result = count * 10.90;
                    }
                    else if (day == "Saturday")
                    {
                        if (count >= 100) result = count * 15.60 - (10 * 15.60);
                        else result = count * 15.60;
                    }
                    else
                    {
                        if (count >= 100) result = count * 16 - (10 * 16);
                        else result = count * 16;
                    }
                    break;
                case "Regular":
                    if (day == "Friday")
                    {
                        if (count >= 10 && count <= 20) result = count * 15 - 0.05 * (count * 15);
                        else result = count * 15;
                    }
                    else if (day == "Saturday")
                    {
                        if (count >= 10 && count <= 20) result = count * 20 - 0.05 * (count * 20);
                        else result = count * 20;
                    }
                    else
                    {
                        if (count >= 10 && count <= 20) result = count * 22.50 - 0.05 * (count * 22.50);
                        else result = count * 22.50;
                    }
                    break;
            }
            Console.WriteLine($"Total price: {result:f2}");
        }
    }
}
