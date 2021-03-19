using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Bus : IVehicle
    {
        public bool Airbag {
            get
            {
                return Airbag;
            }
            set
            {
                Airbag=value;
            }
        }

        public void Drive()
        {
            Console.WriteLine("Driving a Bus");
        }

        public void Drive(int kmph)
        {
            Console.WriteLine("Driving a Bus at "+kmph);
        }

        public void Reverse()
        {
            Console.WriteLine("Reverse a Bus");
        }
    }
}
