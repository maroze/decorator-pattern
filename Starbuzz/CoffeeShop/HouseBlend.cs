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
            description = "Домашняя смесь";
        }

        public override double Cost()
        {
            return 0.89;
        }
       
    }
}
