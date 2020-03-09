using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings
{
    class Book
    {
        public string Title { get; set; }
        public int PageNumber { get; set; }

        public Book(string title, int pageNumber)
        {
            Title = title;
            PageNumber = pageNumber;
        }


        public void Read()
        {
            Console.WriteLine($"I have read {PageNumber} pages of {Title}.");
            Console.ReadLine();
        }
    }
}
