using System;

namespace OOP_.Net
{
    class Program
    {
        static void Main(string[] args)
        {
            var chanuka = new Person(24, 100);
            var dilini = new Person(21, 90);
            var tharun = new Person(15, 80);

            chanuka.TellLifeStory();
            dilini.TellLifeStory();
            tharun.TellLifeStory();
        }

    }
}
