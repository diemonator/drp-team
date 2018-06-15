using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookConverter
{
    class PdfAdapter : IExportHelper
    {
        public string Export(string path, Library library)
        {
            PdfHelper pdfhelp = new PdfHelper();
            string s = pdfhelp.GetConvertedString();
            return s;
        }
    }
}
