using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());

            int max_courses = count / max;
            int leftover = count % max;

            if (count <= max) Console.WriteLine(1);
            else if (leftover == 0) Console.WriteLine(max_courses);
            else Console.WriteLine(max_courses+1);
        }
    }
}
