using System;
using System.Text;

namespace Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char previousChar = input[0];
            Console.Write(previousChar);
            for (int i = 1; i < input.Length; i++)
            {
                if(input[i]!=previousChar)
                {
                    previousChar = input[i];
                    Console.Write(input[i]);
                }
            }

        }
    }
}
