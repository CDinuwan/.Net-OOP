using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_.Net
{
    public abstract class Vehicle
    {
        public virtual void TurnOn()
        {
            Console.WriteLine("Turn on");
        }
        public virtual void TurnOff()
        {
            Console.WriteLine("Turn off");
        }
        public abstract bool AirBag { get; }
    }
}
