using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Harmanpreet Singh
 * Date: July 28, 2017
 * Description: This is the TerrestrialPlanet sub class derived from Planet base Class using 
 * two interfaces(IHasMoons and IHabitable)
 * Version: 0.1 Created class
 */

namespace AbstractPlanet_300931446
{
    /// <summary>
    /// This is the TerrestrialPlanet Class
    /// </summary>
    public class TerrestrialPlanet : Planet, IHasMoons, IHabitable
    {
        //Private Instance Variables
        private bool _oxygen;
        //Constructor
        /// <summary>
        /// This is the main constructor for TerrestrialPlanet Class
        /// It takes 4 arguments - name(string), diameter(double), mass(double) and oxygen(bool)
        /// 3 of these arguments are derived from Planet class
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        /// <param name="oxygen"></param>
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen) : base(name, diameter, mass)
        {
            _oxygen = oxygen;
        }
        //Public Methods
        public bool HasMoons()
        {
            if (MoonCount > 0)
                return true;
            else
                return false;
        }
        public bool Habitable()
        {
            if (_oxygen == true)
                return true;
            else
                return false;
        }

    }
}