using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_.Net
{
    class Person
    {
        public int Age { get; set; }
        public int Energy { get; set; }

        public Person(int age,int energy)
        {
            this.Age = age;
            this.Energy = energy;
        }
        public void TellLifeStory()
        {
            Console.WriteLine("My age is "+Age+" and my energy is "+Energy);
        }
    }
}
