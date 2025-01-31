using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransportSystem
{
    public class Motorcycle : Vehicle
{
    public bool HasSidecar { get; set; }

    public Motorcycle(string make, string model, int year, bool hasSidecar)
        : base(make, model, year)
    {
        HasSidecar = hasSidecar;
    }

    public override void Start()
    {
        Console.WriteLine($"Мотоцикл {Make} {Model} заведен.");
    }

    public override void Stop()
    {
        Console.WriteLine($"Мотоцикл {Make} {Model} остановлен.");
    }
}
}