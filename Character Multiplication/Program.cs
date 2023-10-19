using System;

namespace Character_Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console
                .ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string str1 = input[0];
            string str2 = input[1];

            int sum = 0;

            if(str1.Length>str2.Length)
            {
                string pom = str1;
                str1 = str2;
                str2 = pom;
            }
            int endIndex = 0;
            for (int i = 0; i < str1.Length; i++)
            {
                int code1 = (int)str1[i];
                int code2 = (int)str2[i];

                sum += code1 * code2;
                endIndex++;
            }

            for (int i = endIndex; i < str2.Length; i++)
            {
                sum += (int)str2[i];
            }
            Console.WriteLine(sum);
        }
    }
}
