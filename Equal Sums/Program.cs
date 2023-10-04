using System;
using System.Linq;

namespace Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int leftSum =0;
            int rightSum = 0;
            int br = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                leftSum = 0;
                rightSum = 0;
                if(i>0)
                { 
                    for (int j = i-1; j >= 0; j--)
                    {
                        leftSum += numbers[j];
                    }
                }
                else
                {
                    leftSum = 0;
                }
                if (i < numbers.Length-1)
                {
                    for (int k = i + 1; k < numbers.Length; k++)
                    {
                        rightSum += numbers[k];
                    }
                }
                else
                { 
                    rightSum=0;
                }
                if (leftSum==rightSum)
                {
                    br++;
                    Console.WriteLine(i);
                }
            }
            if (br==0)
            { 
                Console.WriteLine("no");
            }
        }
    }
}
