﻿using System;

namespace Ascii_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            for (int i = start; i <= end; i++)
            {
                Console.Write("{0}", (char)i + " ");
            }
            Console.WriteLine();
        }

    }
}
