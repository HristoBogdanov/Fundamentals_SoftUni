using System;

namespace Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");
            int element=0;
            int br=0;
            for (int i = 0; i < input.Length; i++)
            {
                br = 0;
                element = int.Parse(input[i]);
                for (int j = i+1; j < input.Length; j++)
                {
                    if (element <= int.Parse(input[j]))
                    {
                        br++;
                    }
                }
                if (br==0) Console.Write($"{element} ");
            }
        }
    }
}
