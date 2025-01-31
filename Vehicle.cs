using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransportSystem
{
    public abstract class Vehicle : IVehicle
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public Vehicle(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }

    public string GetInfo()
    {
        return $"Марка: {Make}, Модель: {Model}, Год: {Year}";
    }

    public abstract void Start();
    public abstract void Stop();
}
}