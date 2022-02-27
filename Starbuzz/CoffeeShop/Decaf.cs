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
        public override double Cost()
        {
            return Rate += 120;
        }
    }
}
