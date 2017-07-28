using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Ngan Nguyen - ID:300922400
 * Date: July 28, 2017
 * Description: implement the GiantPlanet class and TerrestrialPlanet class
 * Version: 0.1 - First trial to check the output
 */

namespace NganNguyen_Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            GiantPlanet Jupiter = new GiantPlanet("Jupiter", 69911,1.88*Math.Pow(10.00,27.00), "Gas");
            Jupiter.MoonCount = 4;
            Jupiter.RingCount = -2;
            Console.WriteLine(Jupiter.ToString());
            // display the type??
            //Console.WriteLine("The types is" + Mars.GetType());
            Console.WriteLine("Has Moons on this planet?" + Jupiter.HasMoons());
            Console.WriteLine("Has Rings on this planet?" + Jupiter.HasRings());
            TerrestrialPlanet Mars = new TerrestrialPlanet("Mars", 4200, 6.39 * Math.Pow(10.00, 23.00), false);
            Mars.MoonCount = 0;
            Jupiter.RingCount = -1;
            Console.WriteLine("Has Moons on this planet?" + Mars.HasMoons());
            Console.WriteLine("Has Habitable on this planet?" + Mars.Habitable());
            //display oxygen??
        }
    }
}
