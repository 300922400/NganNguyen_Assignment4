using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Ngan Nguyen - ID:300922400
 * Date: July 26, 2017
 * Description: This is the TerrestrialPlanet subclass  
 * derive from the Planet Abstract Class
 * Version: 0.1 - Create the TerresstrialPlanet subclass
 */

    /// <summary>
    /// this is TerresstrialPlanet
    /// </summary>
namespace NganNguyen_Assignment4
{
    public class TerrestrialPlanet:Planet,IHasMoons,IHabitable
    {
        //private instance variables
        private bool _oxygen;
        //public properties
        /// <summary>
        /// This is main constructor for TerrestrialPlanet
        /// There have 4 parameters:name(string),diameter(double),mass(double),oxygen(bool)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        /// <param name="oxygen"></param>
        // contructor
        public TerrestrialPlanet(string name, double diameter, double mass,bool oxygen)
            :base(name,diameter,mass)
        {
            this._oxygen = oxygen;
        }
        //private methods
        //public methods
        public bool HasMoons()
        {
            if (MoonCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Habitable()
        {
            if (_oxygen == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}