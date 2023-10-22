using System;
using System.Collections.Generic;

namespace Raiding
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BaseHero> heroes = new List<BaseHero>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <n; i++)
            {
                string nameHero = Console.ReadLine();
                string typeHero = Console.ReadLine();

                switch(typeHero)
                {
                    case "Druid":
                        Druid druid = new Druid(nameHero);
                        heroes.Add(druid);
                        break;
                    case "Paladin":
                        Paladin paladin = new Paladin(nameHero);
                        heroes.Add(paladin);
                        break;
                    case "Rogue":
                        Rogue rogue = new Rogue(nameHero);
                        heroes.Add(rogue);
                        break;
                    case "Warrior":
                        Warrior warrior = new Warrior(nameHero);
                        heroes.Add(warrior);
                        break;
                    default:
                        Console.WriteLine("Invalid hero!");
                        break;
                }
            }
            int bossPower = int.Parse(Console.ReadLine());
            
            foreach(BaseHero h in heroes)
            {
                Console.WriteLine(h.CastAbility());
                bossPower -=h.ReturnPower();
            }
            if(bossPower<=0)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}
