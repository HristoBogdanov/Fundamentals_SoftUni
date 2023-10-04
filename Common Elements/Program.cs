using System;

namespace Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            string[] a1 = input1.Split(" ");
            string[] a2 = input2.Split(" ");

            for (int i = 0; i < a1.Length; i++)
            {
                for (int j = 0; j < a2.Length; j++)
                {
                    if (a1[i] == a2[j]) Console.Write($"{a1[i]} ");
                }
            }
        }
    }
}
