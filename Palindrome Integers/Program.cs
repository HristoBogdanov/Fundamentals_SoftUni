using System;

namespace Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while(input!="END")
            {
                int number = int.Parse(input);
                if (number == ReverseNumber(number))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }

                input = Console.ReadLine();
            }
        }
        static int ReverseNumber(int a)
        {
            string st = a.ToString();
            string stReverse = string.Empty;
            for (int i = st.Length-1; i >= 0; i--)
            {
                stReverse += st[i];
            }

            return int.Parse(stReverse);
        }
    }
}
