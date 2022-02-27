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
            dr.SetMilk();
            df.SetMocha();
            es.SetWhip();
            hb.SetSoy();
            Beverage[] beverages = new Beverage[] { dr, df, es, hb };
            foreach (var bev in beverages)
            {
                Console.WriteLine($"{bev.GetDescription()} - стоимость: " + $"{bev.Cost()} " + $"руб");
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
