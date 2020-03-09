using System;

namespace FavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var hero = new Avenger("Iron Man", "blasters");
            hero.Assemble();

            var film = new Movie("Dodgeball", 134);
            film.Showtime();

            var book = new Book("To Kill a Mockingbird", 120);
            book.Read();

            var vehicle = new Car("Jeep", 15);
            vehicle.Whole();
        }
    }
}
