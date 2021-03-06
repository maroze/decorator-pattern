using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuzz
{
    public class Soy: CondimentDecorator
    {
        Beverage beverage;
        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Соя";
        }
        public override double Cost()
        {
            return beverage.Cost() + 0.15;
        }
    }
}
