using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_Exam_Net_Framework_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal neededExp = decimal.Parse(Console.ReadLine());
            if (neededExp <= 0)
            {
                Console.WriteLine($"Player successfully collected his needed experience for 0 battles.");
                return;
            }
            int countBattles = int.Parse(Console.ReadLine());

            for (int i = 1; i <= countBattles; i++)
            {
                decimal expGained = decimal.Parse(Console.ReadLine());
                if (i % 3 == 0)
                {
                    neededExp -= (expGained + expGained * 0.15m);
                }
                else if (i % 5 == 0)
                {
                    neededExp -= (expGained - expGained * 0.1m);
                }
                else if (i % 15 == 0)
                {
                    neededExp -= (expGained + expGained * 0.05m);
                }
                else
                {
                    neededExp -= expGained;
                }

                if (neededExp <= 0)
                {
                    Console.WriteLine($"Player successfully collected his needed experience for {i} battles.");
                    break;
                }
            }
            if (neededExp > 0)
            {
                Console.WriteLine($"Player was not able to collect the needed experience, {neededExp:f2} more needed.");
            }
        }
    }
}
