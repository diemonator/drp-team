using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BookConverter
{
    class XmlAdapter : IExportHelper
    {
        XmlDocument xmldoc;
        public XmlAdapter()
        {
<<<<<<< HEAD
            xmldoc = new XmlDocument();
        }
        public bool Export(string path, Library library)
        {
            return false;
=======

        }
        public bool Export(string path, Library library)
        {
            throw new NotImplementedException();
>>>>>>> master
        }
    }
}
