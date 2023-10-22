using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public abstract class BaseHero
    {
        public string Name;

        protected BaseHero(string name)
        {
            Name = name;
        }

        public abstract string CastAbility();
        public abstract int ReturnPower();
    }
}
