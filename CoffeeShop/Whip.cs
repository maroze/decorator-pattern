using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuzz
{
    public class Whip: CondimentDecorator
    {
        Beverage beverage;
        public Whip (Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Взбитые сливки";
        }
        public override double Cost()
        {
            return beverage.Cost() + 0.10;
        }
    }
}
