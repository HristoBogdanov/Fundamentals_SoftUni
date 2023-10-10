using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = "";
            for (int i = username.Length-1; i >=0; i--)
            {
                password += $"{username[i]}";
            }
            for (int i = 0; i < 4; i++)
            { 
                string try_p= Console.ReadLine();
                if (i >= 3 && try_p!=password)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                else 
                {
                    if (try_p == password)
                    {
                        Console.WriteLine($"User {username} logged in.");
                        break;
                    }
                    else Console.WriteLine("Incorrect password. Try again.");
                }
                
            }
        }
    }
}
