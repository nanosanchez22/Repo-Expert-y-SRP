using System;
using System.Collections.Generic;

namespace SRP
{
    public class Shelf{

        public string ShelfName { get ; set;} 
        public List<Book> Books { get; set; } = new List<Book>();

    }
}
