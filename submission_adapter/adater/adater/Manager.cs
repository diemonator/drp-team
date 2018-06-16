using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookConverter
{
    public class Manager
    {
        private static Library library = new Library();
        private string result = "";

        public string ToString(int numForFileFormat, int numForBook)
        {
            if (numForFileFormat == 1)
            {
                XmlAdapter xml = new XmlAdapter();
                result = library.ExportTo("path for file", xml);
            }
            else if (numForFileFormat == 2)
            {
                PdfAdapter pdf = new PdfAdapter();
                result = library.ExportTo("path for file", pdf);
            }
            return result;
        }

        public List<string> GetListOfBooks()
        {
            List<string> list = new List<string>();
            foreach (Book b in library.Books)
            {
                list.Add(b.Name + " - " + b.Author);
            }
            return list;
        }

    }
}
