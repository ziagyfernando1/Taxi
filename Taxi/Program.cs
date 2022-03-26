using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    public class Program
    {
        static void Main(string[]args)
        {
            //membuat object taxi
            Taxi taxi = new Taxi();

            //pengesatan nilai propertis
            taxi.DriverName = "Jono";
            taxi.OnDuty = true;
            taxi.Numpassenger = 10;

            //pemanggilan method
            taxi.TaxiInfo();
            taxi.PickupPassanger();
            taxi.DropOffPassanger();

            Console.ReadKey();
        }
    }
}