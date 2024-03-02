using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiclepicker
{
    public class FuelCar: Vehicle
    {
        public int FuelCapacity { get; set; }
        public override void PickCar(int number)
        {
            base.Equals(number);
            Console.WriteLine($"Fuel Capacity is: {FuelCapacity}");
        }
    }
}
