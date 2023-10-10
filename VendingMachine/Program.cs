using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double wallet = 0;
            while (input != "Start")
            {
                double coin = double.Parse(input);
                if (coin != 0.1 && coin != 0.2 && coin != 0.5 && coin != 1 && coin != 2) Console.WriteLine($"Cannot accept {coin}");
                else wallet += coin;
                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            while (input != "End")
            {
                switch (input)
                {
                    case "Nuts":
                        if (wallet >= 2)
                        {
                            Console.WriteLine($"Purchased nuts");
                            wallet -= 2;
                        }
                        else Console.WriteLine("Sorry, not enough money");
                        break;
                    case "Water":
                        if (wallet >= 0.7)
                        {
                            Console.WriteLine($"Purchased water");
                            wallet -= 0.7;
                        }
                        else Console.WriteLine("Sorry, not enough money");
                        break;
                    case "Crisps":
                        if (wallet >= 1.5)
                        {
                            Console.WriteLine($"Purchased crisps");
                            wallet -= 1.5;
                        }
                        else Console.WriteLine("Sorry, not enough money");
                        break;
                    case "Soda":
                        if (wallet >= 0.8)
                        {
                            Console.WriteLine($"Purchased soda");
                            wallet -= 0.8;
                        }
                        else Console.WriteLine("Sorry, not enough money");
                        break;
                    case "Coke":
                        if (wallet >= 1)
                        {
                            Console.WriteLine($"Purchased coke");
                            wallet -= 1;
                        }
                        else Console.WriteLine("Sorry, not enough money");
                        break;
                    default:Console.WriteLine("Invalid product");
                        break;

                       
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Change: {wallet:f2}");
        }
    }
}
