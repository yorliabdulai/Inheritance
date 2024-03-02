using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiclepicker
{
    public class ElectricCar: Vehicle
    {
        public int Batterycapacity { get; set; }
        public override void PickCar(int number)
        {
            base.Equals(number);
            Console.WriteLine($"Battery Capacity: {Batterycapacity} kwh");
        }
    }
}
