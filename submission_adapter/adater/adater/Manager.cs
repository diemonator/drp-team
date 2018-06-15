using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookConverter
{
    public class Manager
    {
        private static Library lib;
        string s = "";
        public Manager()
        {}

        public string ToString(int numForFileFormat, int numForBook)
        {
            lib = new Library();
            if (numForFileFormat == 1)
            {
                XmlAdapter xml = new XmlAdapter();
                s = lib.ExportTo("path for file", xml);
            }
            else if (numForFileFormat == 2)
            {
                PdfAdapter pdf = new PdfAdapter();
                s = lib.ExportTo("path for file", pdf);
            }
            return s;
        }

        public List<string> GetListOfBooks()
        {
            lib = new Library();
            List<string> list = new List<string>();
            foreach (Book b in lib.Books)
            {
                list.Add(b.Name + " - " + b.Author);
            }
            return list;
        }

    }
}
