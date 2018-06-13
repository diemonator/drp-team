using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookConverter
{
    class Library
    {
        private List<Book> books;

        public Library()
        {
            books = new List<Book>();
        }

        public bool ExportTo(string path, IExportHelper helper)
        {
            return helper.Export(path, this);
        }
    }
}
