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
            description = "Темн. обжарка";
        }
        public override double Cost()
        {
            return 0.99;
        }

    }
}
