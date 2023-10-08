using System;

namespace Latin_Triples
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            char charA = '`';
            char charB = '`';
            char charC = '`';

            for (int i = 0; i < count; i++)
            {

                charA++;
                charB = '`';
                for (int j = 0; j < count; j++)
                {

                    charB++;
                    charC = '`';

                    for (int k = 0; k < count; k++)
                    {

                        charC++;
                        Console.WriteLine($"{charA}{charB}{charC}");


                    }
                }
            }
        }
    }
}
