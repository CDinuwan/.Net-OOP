using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Laptop : Computer
    {
        public bool Gaming => false;

        public void TurnOff()
        {
            Console.WriteLine("Laptop TurnOff");
        }

        public void TurnOn()
        {
            Console.WriteLine("Laptop TurnOn");
        }
    }
}
