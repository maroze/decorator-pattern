using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuzz
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            Description = "Прекрасно сбалансированный кофе с нотками орехов и какао";
        }

        public override double Coast()
        {
            return 150 + base.Coast();
        }
        public override bool HasMilk()
        {
            return true;
        }

        public override bool HasMocha()
        {
            return true;
        }

        public override bool HasSoy()
        {
            return true;
        }

        public override bool HasWhip()
        {
            return true;
        }
    }
}
