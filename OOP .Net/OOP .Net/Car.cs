using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_.Net
{
    public class Car : Vehicle
    {
        public override bool AirBag => true;
        public override void TurnOn()
        {
            Console.WriteLine("Car switchOn");
        }
    }
}
