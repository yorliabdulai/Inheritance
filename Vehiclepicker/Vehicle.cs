namespace Vehiclepicker
{
    public class Vehicle
    {
        public string Model { get; set; }
        public int Year { get; set; }

        public virtual void PickCar(int number)
        {
           /* if (number % 2 == 0)
            {
                Console.WriteLine($"Picked an Electric car - Model: {Model}, Year: {Year}");
            }
            else
            {
                Console.WriteLine($"Picked a fuel car - Model: {Model}, Year: {Year}");
            } */
        } 
    }
}
