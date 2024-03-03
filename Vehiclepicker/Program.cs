using System.Reflection;
using Vehiclepicker;

class Program
{
    static void Main()
    {
        Vehicle vehicle = new Vehicle { Model = "Toyota", Year = 2025 };
        ElectricCar electricCar = new ElectricCar { Batterycapacity = 80 };
        FuelCar fuelCar = new FuelCar { FuelCapacity = 2000 };
        int randomNumber = new Random().Next(1, 99);
        Console.WriteLine($"Random number: {randomNumber}");
        if (randomNumber % 2 == 0)
        {
            Console.WriteLine($"Picked an Electric car - Model: {vehicle.Model}, Year: {vehicle.Year}, Battery Capacity: {electricCar.Batterycapacity}");
        }
        else
        {
            Console.WriteLine($"Picked a fuel car - Model: {vehicle.Model}, Year: {vehicle.Year}, Fuel Capacity: {fuelCar.FuelCapacity}");
        }
    }
}