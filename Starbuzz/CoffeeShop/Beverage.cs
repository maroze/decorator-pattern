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
           return Description ;
        }
        public double Rate;
        abstract public double Cost();

        public string SetMilk()
        {
            return $"{Description += " + milk"} {Rate += milk}";
        }
        public string SetSoy()
        {
            return $"{Description += " + soy"} {Rate += soy}";
        }
        public string SetMocha()
        {
            return $"{Description += " + mocha"} {Rate += mocha}";
        }
        public string SetWhip()
        {
            return $"{Description += " + whip"} {Rate += whip}";
        }
    }
}
