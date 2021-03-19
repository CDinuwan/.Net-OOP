using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var laptop = new Laptop();

            Console.WriteLine(laptop.Gaming);

            laptop.TurnOn();
            laptop.TurnOff();

        }
    }
}
