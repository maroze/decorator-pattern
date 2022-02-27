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
            Description = "Домашняя обжарка";
        }
        public override double Cost()
        {
            return Rate += 200;
        }
    }
}
