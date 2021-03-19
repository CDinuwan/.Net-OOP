using System;

namespace OOP_.Net
{
    class Program
    {
        static void Main(string[] args)
        {
            var chanuka = new Person(24, 100);
            var dilini = new Person(21, 90);
            var rukshani = new Person(15, 80);

            chanuka.TellLifeStory();
            dilini.TellLifeStory();
            rukshani.TellLifeStory();

            Vehicle car = new Car();
            Vehicle bus = new Bus();

            car.TurnOn();
            car.TurnOn();

            bus.TurnOn();
            bus.TurnOff();

            Console.WriteLine(car.AirBag);
            Console.WriteLine(bus.AirBag);
        }

    }

}
