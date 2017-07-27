using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Harmanpreet Singh
 * Date: July 27, 2017
 * Description: This is the abstract class Planet which other subclasses will
 * derive from.
 * Version: 0.3 - Added Public Properties
 */
namespace AbstractPlanet_300931446
{
    /// <summary>
    /// This is the abstract Class
    /// </summary>
    abstract class Planet
    {
        //Private Fields(Instance Variables)
        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;

        //Public Properties
        public double Diameter
        {
            get
            {
                return this._diameter;
            }
        }
        public double Mass
        {
            get
            {
                return this._mass;
            }
        }
        public int MoonCount
        {
            get
            {
                return this._moonCount;
            }
            set
            {
                this._moonCount = value;
            }
        }
        public string Name
        {
            get
            {
                return this._name;
            }

        }
        public double OrbitalPeriod
        {
            get
            {
                return this._orbitalPeriod;
            }
            set
            {
                this._orbitalPeriod = value;
            }

        }
        public int RingCount
        {
            get
            {
                return this._ringCount;
            }
            set
            {
                this._ringCount = value;
            }
        }
        public double RotationPeriod
        {
            get
            {
                return this._rotationPeriod;
            }
            set
            {
                this._rotationPeriod = value;
            }
        }

        //Constructors

        //Public Methods
    }
}
