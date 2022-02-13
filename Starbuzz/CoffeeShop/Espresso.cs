using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuzz
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            Description = "Эспрессо";
        }

        public override double Coast()
        {
            return 135 + base.Coast();
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
            return true;
        }
    }
}
