using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings
{
    class Movie
    {
        public string Name { get; set; }
        public int Runtime { get; set; }

        public Movie(String name, int runtime)
        {
            Name = name;
            Runtime = runtime;
        }

        public void Showtime()
        {
            Console.WriteLine($"The next showing of {Name} is tomorrow at 12:00pm and runs for {Runtime} minutes.");
            Console.ReadLine();
        }

    }
}
