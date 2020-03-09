using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings
{
    class Car
    {
        public string Brand { get; set; }
        public int Tires { get; set; }

        public Car(string brand, int tires)
        {
            Brand = brand;
            Tires = tires;
        }
        public void Whole()
        {
            Console.WriteLine($"This {Brand} comes with {Tires} tires. The real deal.");
            Console.ReadLine();
        }
    }
}
