using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public class Warrior : BaseHero
    {
        public string Name;
        public int Power;

        public Warrior(string name) : base(name)
        {
            Name = name;
            Power = 100;
        }

        public override string CastAbility()
        {
            return $"{this.GetType().Name} - {Name} hit for {Power} damage";
        }

        public override int ReturnPower()
        {
            return this.Power;
        }
    }
}
