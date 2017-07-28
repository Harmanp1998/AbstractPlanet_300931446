using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Harmanpreet Singh
 * Date: July 28, 2017
 * Description: This is the GiantPlanet sub class derived from Planet base Class using 
 * two interfaces(IHasMoons and IHasRings)
 * Version: 0.1 Created class
 */
namespace AbstractPlanet_300931446
{
    class GiantPlanet : Planet,IHasMoons,IHasRings
    {
        //Private Instance Variables
        private string _type;

 
        //CONSTRUCTOR----------------------------------------------------
        /// <summary>
        /// This is a GiantPlanet constructor that takes 4 arguments.
        /// name(string), diameter(double),mass(double) and type(string)
        /// 3 of them are derived from planet base class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        /// <param name="type"></param>
        public GiantPlanet(string name, double diameter, double mass, string type) : base(name, diameter, mass)
        {
            _type = type;
        }
        //Public Methods
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
        public bool HasRings()
        {
            if (RingCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class GIantPLanet
    {
    }
}
