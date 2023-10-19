using System;

namespace Extract_file
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console
                .ReadLine()
                .Split(@"\", StringSplitOptions.RemoveEmptyEntries);

            string pom = input[input.Length - 1];

            string[] neededInfo = pom
                .Split(".", StringSplitOptions.RemoveEmptyEntries);

            string nameFile = neededInfo[0];
            string extension = neededInfo[1];

            Console.WriteLine($"File name: {nameFile}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
