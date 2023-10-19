using System;
using System.Text;

namespace Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder result = new StringBuilder();

            foreach (var ch in input)
            {
                int value = (int)ch;
                value += 3;
                result.Append((char)value);
            }
            Console.WriteLine(result);
        }
    }
}
