using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public class Rogue : BaseHero
    {
        public string Name;
        public int Power;

        public Rogue(string name) : base(name)
        {
            Name = name;
            Power = 80;
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
