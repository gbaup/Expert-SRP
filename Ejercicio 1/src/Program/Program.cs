using System;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns", "Erich Gamma & Others", "001-034");
            Book book2 = new Book("Pro C#", "Troelsen", "001-035");

            var bookLocation1 = new BookLocation() { LibrarySector = "AA", LibraryShelve = "7", Book = book1 };
            var bookLocation2 = new BookLocation();

            bookLocation1.ShelveBook(book1, "A", "7");
            bookLocation2.ShelveBook(book2, "B", "3");



            Console.WriteLine(bookLocation1.Book.Title);

        }
    }
}