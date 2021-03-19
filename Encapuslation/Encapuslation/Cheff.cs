using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapuslation
{
    public abstract class Cheff
    {
        public virtual bool HasDegree { get; set; }

        public abstract void SpecialDish();
        public virtual void NormalDish()
        {
            Console.WriteLine("Make Normal Dishes");
        }
        protected virtual void Speciality()
        {
            Console.WriteLine("Rice cooks well by Cheff");
        }

    }
}

