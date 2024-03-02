using Vehiclepicker;

class Program
{
    static void Main()
    {
        ElectricCar electricCar = new ElectricCar { Model = "Tesla", Year = 2023, Batterycapacity = 80 };
        FuelCar fuelCar = new FuelCar { Model = "Ford", Year = 2022, FuelCapacity = 2000 };
        int randomNumber = new Random().Next(1, 99);
        Console.WriteLine($"Random number: {randomNumber}");
        Console.WriteLine($"From Electric Car: {ElectricCar.PickCar(randomNumber)}");
        Console.WriteLine($"From Fuel Car: {FuelCar.PickCar(randomNumber)}");
    }
}