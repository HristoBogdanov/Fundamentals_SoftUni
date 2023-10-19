using System;

namespace String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            // abv>1>1>2>2asdasd
            int strength = 0;
            for (int i = 0; i < input.Length; i++)
            {
                // i=3(>)
                if(strength>0 && input[i]!='>')
                {
                    input= input.Remove(i, 1);
                    strength--;
                    i--;
                }
                else if(input[i]=='>')
                {
                    strength += int.Parse(input[i + 1].ToString());
                }
            }
            Console.WriteLine(input);
        }
    }
}
