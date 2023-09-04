using System;

namespace SRP
{
    public class Book
    {

        public string Title { get; }
        public string Author { get; }
        public string Code { get; }


        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }
    }


    /*
    Podriamos separar la clase en 2. Una que sea book, con toda la inforamcion anteriormente mencionada, 
    y otra que sea BookLocation. La responsabilidad de esta ultima seria informacion "extra" a la basica del libro.
    Basicamente la clase Book tendria la informacion prinicpal y basica del libro, 
    y BookLocation donde encontrar este libro (su ubicacion)
    */
    public class BookLocation
    {
        public string LibrarySector { get; set; }
        public string LibraryShelve { get; set; }
        public Book Book { get; set; }
        public void ShelveBook(Book book, String sector, String shelve)
        {
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
        }

    }
}
