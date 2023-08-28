using System;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            

            Book book1 = new Book("Design Patterns", "Erich Gamma & Others", "001-034");
            Book book2 = new Book("Pro C#", "Troelsen", "001-035");

            Shelf shelfA = new Shelf();
            shelfA.ShelfName = "shelf a";
            Shelf shelfB = new Shelf();
            shelfB.ShelfName = "shelf b";

            Sector sectorA = new Sector();
            sectorA.SectorName = "sector a";

            shelfA.Books.Add(book1);
            shelfB.Books.Add(book2);

            sectorA.Shelf.Add(shelfA);
            sectorA.Shelf.Add(shelfB);

            Console.WriteLine($"Sector: {sectorA.SectorName}");
            foreach (var shelf in sectorA.Shelf)
            {
                Console.WriteLine($"  Shelf: {shelf.ShelfName}");
                foreach (var book in shelf.Books)
                {
                    Console.WriteLine($"    Book: {book.Title} by {book.Author}, Code: {book.Code}");
                }
            }
        
        }
    }
}