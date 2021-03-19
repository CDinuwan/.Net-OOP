using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Car : IVehicle
    {
        public bool Airbag
        {
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
            Console.WriteLine("Driving a car.");
        }

        public void Drive(int kmph)
        {
            Console.WriteLine("Driving a car with "+kmph);
        }

        public void Reverse()
        {
            Console.WriteLine("Get reverse to the car.");
        }
    }
}
