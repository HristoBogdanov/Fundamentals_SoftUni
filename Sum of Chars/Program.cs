using System;
namespace Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {

            byte chars = byte.Parse(Console.ReadLine());
            int result = 0;
            while (chars > 0)
            {
                result += char.Parse(Console.ReadLine());
                chars--;
            }
            Console.WriteLine($"The sum equals: {result}");
        }
    }
}
