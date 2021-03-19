using System;
using System.Collections.Generic;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IVehicle> vehicles = new List<IVehicle>() { new Car(), new Bus() };

            foreach(var vehicle in vehicles)
            {
                vehicle.Drive();
                vehicle.Drive(120);
                vehicle.Reverse();
            }
        }
    }
}
