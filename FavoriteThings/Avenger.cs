using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings
{
    class Avenger
    {
        public string Name { get; set; }
        public string Weapon { get; set; }

        public Avenger(string name, string weapon)
        {
            Name = name;
            Weapon = weapon;
        }

        public void Assemble()
        {
            Console.WriteLine($"It's a good thing {Name} showed up and used his {Weapon}!");
            Console.ReadLine();
        }
    }
}
