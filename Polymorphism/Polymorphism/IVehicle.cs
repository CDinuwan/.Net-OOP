using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public interface IVehicle
    {
        public bool Airbag { get; set; }
        void Drive();
        void Reverse();
        void Drive(int kmph);
    }
}
