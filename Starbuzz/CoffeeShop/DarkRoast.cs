using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuzz
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            Description = "Темный обжаренный кофе";
        }

        public override double Coast()
        {
            return 100 + base.Coast();
        }
        public override bool HasMilk()
        {
            return true;
        }

        public override bool HasMocha()
        {
            return false;
        }

        public override bool HasSoy()
        {
            return false;
        }

        public override bool HasWhip()
        {
            return false;
        }
    }
}
