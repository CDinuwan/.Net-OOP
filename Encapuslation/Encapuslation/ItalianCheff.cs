using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapuslation
{
    class ItalianCheff : Cheff
    {
        public override void SpecialDish()
        {
            Console.WriteLine("Italian cheff makes italian foods");
        }
        public override void NormalDish()
        {
            Console.WriteLine("Cook normal dishes with italian flavour");
            Console.WriteLine("World number 1 Italian cheff");
        }
        public override bool HasDegree => true;
        public void State()
        {
            Console.WriteLine("World number 1 Italian cheff");
        }
    }
}
