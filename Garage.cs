using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransportSystem
{
    public class Garage<T> where T : IVehicle
{
    private List<T> vehicles = new List<T>();

    public void AddVehicle(T vehicle)
    {
        vehicles.Add(vehicle);
        Console.WriteLine("Транспорт добавлен в гараж: " + vehicle.GetInfo());
    }

    public void ShowVehicles()
    {
        Console.WriteLine("Транспорт в гараже:");
        foreach (var vehicle in vehicles)
        {
            Console.WriteLine(vehicle.GetInfo());
        }
    }
}
}