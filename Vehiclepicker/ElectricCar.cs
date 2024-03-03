namespace Vehiclepicker
{
    public class ElectricCar : Vehicle
    {
        public int Batterycapacity { get; set; }

        public override void PickCar(int number)
        {
            base.PickCar(number);
            Console.WriteLine($"Battery Capacity: {Batterycapacity} kwh");
        }
    }
}
