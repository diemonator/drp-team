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
    public class XmlAdapter : IExportHelper
    {
        public string Export(string path, Library library)
        {
            XmlHelper xhelp = new XmlHelper();
            string s = xhelp.GetConvertedString();
            return s;
        }
    }
}
