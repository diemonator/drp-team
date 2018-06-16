using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookConverter
{
    public class Library
    {
        public List<Book> Books { get; private set; }

        public Library()
        {
            Books = new List<Book>()
            {
                new Book("Harry Potter", "J. K. Rowling"),
                new Book("Secret Seven", "Enid Blyton"),
                new Book("Alice's Adventures in Wonderland", "Lewis Carroll")
            };
        }

        public string ExportTo(string path, IExportHelper helper)
        {
            return helper.Export(path, this);
        }
    }
}
