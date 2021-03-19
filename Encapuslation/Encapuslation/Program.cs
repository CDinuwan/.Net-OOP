using System;
using System.Collections.Generic;

namespace Encapuslation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cheff> cheffs = new List<Cheff>() { new ItalianCheff(), new ChinesseCheff()};
            foreach(var cheff in cheffs)
            {
                Console.WriteLine(cheff.HasDegree);
                cheff.NormalDish();
                cheff.SpecialDish();
            }
        }
    }
}
