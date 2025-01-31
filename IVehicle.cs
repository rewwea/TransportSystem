using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransportSystem
{
    public interface IVehicle
    {
        void Start();
        void Stop();
        string GetInfo();
    }
}