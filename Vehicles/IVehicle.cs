using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public interface IVehicle
    {
        public string Drive(double distance);
        public void Refuel(double liters);
        public string Print();
    }
}
