using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name: Harmanpreet Singh
 * Date: July 28, 2017
 * Description: This is the main program
 * Version: 0.2 Implpemented TerrestrialPLanet and GiantPLanet in Driver class
 */
namespace AbstractPlanet_300931446
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++");
            GiantPlanet giantPlanet = new GiantPlanet("Saturn", 116464, 48000000,"Gas");
            Console.WriteLine(giantPlanet.ToString());
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++");
            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("Jupiter",304759,89435012,true);
            Console.WriteLine(terrestrialPlanet.ToString());
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++");
        }
    }
}
