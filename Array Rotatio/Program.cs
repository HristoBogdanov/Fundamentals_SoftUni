using System;

namespace Array_Rotatio
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] start = Console.ReadLine().Split(" ");
            int count = int.Parse(Console.ReadLine());
            string firstElement = "";

            for(int j=0;j<count;j++)
            {
                firstElement = start[0];
                for (int i = 0; i < start.Length-1; i++)
                {
                    start[i] = start[i+1];
                }
                start[start.Length - 1] = firstElement;
            }
            foreach(string x in start) Console.Write($"{x} ");
        }
    }
}
