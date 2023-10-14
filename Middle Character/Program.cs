using System;

namespace Middle_Character
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = string.Empty;

            Console.WriteLine(MiddleCharacter(input,result));
        }
        static string MiddleCharacter(string input,string result)
        {
            if (input.Length % 2 == 0)
            {
                result += input[input.Length / 2 - 1];
                result += input[input.Length / 2];
            }
            else
            {
                result += input[input.Length / 2 ];
            }
            return result;
        }
    }
}
