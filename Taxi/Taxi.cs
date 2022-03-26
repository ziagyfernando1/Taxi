using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    public class Taxi
    {
        //properties
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int Numpassenger { get; set; }

        //method
        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name: {0}", DriverName);
            Console.WriteLine("On Duty: {0}", OnDuty);
            Console.WriteLine("Number Of Passanger: {0}\n", Numpassenger);
        }
        public void PickupPassanger()
        {
            Console.WriteLine("{0} Sedang Menjemput Penumpang", DriverName);
        }
        public void DropOffPassanger()
        {
            Console.WriteLine("{0} Selesai Mengantar Penumpang", DriverName);
        }
        
    }
}
