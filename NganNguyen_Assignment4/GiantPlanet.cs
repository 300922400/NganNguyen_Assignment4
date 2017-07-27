using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Ngan Nguyen
 * Date: July 25, 2017
 * Description: This is the GiantPlanet subclass  
 * derive from the Planet Abstract Class
 * Version: 0.2 - Modify the GiantPlanet subclass by adding 2 methods: HasMoons, HasRings
 */

    /// <summary>
    /// This is GiantPlanet Class
    /// </summary>
namespace NganNguyen_Assignment4
{
    public class GiantPlanet:Planet,IHasMoons,IHasRings
    {
        //private  instance variables
        private string _type;
        //public properties
        //constructors
        public GiantPlanet(string name, double diameter, double mass, string type)
            :base (name,diameter,mass)
        {
            this._type = type;
        }
        //private methods

        //public methods
        public bool HasMoons()
        {
            if (MoonCount > 0)
            {
                return true;
            }
            else return false;
        }
        public bool HasRings()
        {
            if (RingCount > 0)
            {
                return true;
            }
            else return false;
        }
    }
}
