using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuzz
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            Description = "Кофе без кофеина";
        }

        public override double Coast()
        {
            return 120 + base.Coast();
        }
        public override bool HasMilk()
        {
            return false;
        }

        public override bool HasMocha()
        {
            return false;
        }

        public override bool HasSoy()
        {
            return true;
        }

        public override bool HasWhip()
        {
            return false;
        }
    }
}
