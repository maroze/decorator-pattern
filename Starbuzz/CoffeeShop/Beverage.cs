using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuzz
{
    public abstract class Beverage
    {
        protected double milk = 10;
        protected double soy = 15;
        protected double mocha = 20;
        protected double whip = 10;
        protected string Description;

        public string GetDescription()
        {
            return Description;
        }

        public virtual double Coast()
        {
            double cost = 0;
            if (HasMilk())
            {
                cost += milk;
            }

            if (HasSoy())
            {
                cost += soy;
            }

            if (HasMocha())
            {
                cost += mocha;
            }

            if (HasWhip())
            {
                cost += whip;
            }

            return cost;
        }

        public abstract bool HasMilk();
        public abstract bool HasSoy();
        public abstract bool HasMocha();
        public abstract bool HasWhip();
    }
}
