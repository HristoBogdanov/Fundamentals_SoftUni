using System;

namespace Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());

            int first = (int)a;
            int last = (int)b;
            if (first > last)
            {
                int pom = first;
                first = last;
                last = pom;
            }

            PrintCharacters(first, last);
        }
        static void PrintCharacters(int first,int last)
        {
            for (int i = first + 1; i < last; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
