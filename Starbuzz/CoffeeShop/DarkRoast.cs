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
        public override double Cost()
        {
            return Rate += 100;
        }
    }
}
