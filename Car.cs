using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransportSystem
{
    public class Car : Vehicle
{
    public int NumberOfDoors { get; set; }

    public Car(string make, string model, int year, int numberOfDoors)
        : base(make, model, year)
    {
        NumberOfDoors = numberOfDoors;
    }

    public override void Start()
    {
        Console.WriteLine($"Автомобиль {Make} {Model} заведен.");
    }

    public override void Stop()
    {
        Console.WriteLine($"Автомобиль {Make} {Model} остановлен.");
    }
}

}