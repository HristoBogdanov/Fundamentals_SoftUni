using System;

namespace Print_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            string result = $"{start}";
            int sum = start;

            for (int i = start+1; i < end; i++)
            {
                result += $" {i}";
                sum += i;
            }
            result += $" {end}";
            sum += end;
            Console.WriteLine(result);
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
