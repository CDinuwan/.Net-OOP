using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapuslation
{
    class ChinesseCheff : Cheff
    {
        public override bool HasDegree { get => base.HasDegree; set => base.HasDegree = value; }
        public override void SpecialDish()
        {
            Console.WriteLine("Chinese cheff make chinese foods");
            Speciality();
        }
        public override void NormalDish()
        {
            base.NormalDish();                                                        
        }
        protected override void Speciality()
        {
            base.Speciality();
        }
    }
}
