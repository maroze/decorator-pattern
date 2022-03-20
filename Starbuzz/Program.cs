using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage dr = new DarkRoast();
            Beverage df = new Decaf();
            Beverage es = new Espresso();
            Beverage hb = new HouseBlend();
           
            dr = new Milk(dr);
            dr = new Mocha(dr);

            hb = new Soy(hb);

            es = new Whip(es);
            es = new Soy(es);
            es = new Milk(es);
            es = new Mocha(es);

            Beverage[] beverages = new Beverage[] { dr, df, es, hb };
            foreach (var bev in beverages)
            {
                Console.WriteLine($"{bev.GetDescription()} " + $"${bev.Cost()} ");
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
