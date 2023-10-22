using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public class Druid : BaseHero
    {
        public string Name;
        public int Power;

        public Druid(string name) : base(name)
        {
            Name = name;
            Power = 80;
        }

        public override string CastAbility()
        {
            return $"{this.GetType().Name} - {Name} healed for {Power}";
        }

        public override int ReturnPower()
        {
            return this.Power;
        }
    }
}
