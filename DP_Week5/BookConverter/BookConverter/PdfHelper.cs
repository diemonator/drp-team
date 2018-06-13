<<<<<<< HEAD
﻿using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookConverter
{
    class PdfHelper : IExportHelper
    {
        public bool Export(string path, Library library)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\Mrunal Patil\Desktop\Fontys_Tue\Fontys\Semester4\BLOCK4\DPR\DPR-repo\dpr\DP_Week5\BookConverter\BookConverter\dummydata.txt");
            Document doc = new Document(iTextSharp.text.PageSize.A4, 10, 10, 10, 10);
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream("dpr.pdf", FileMode.Create));
            doc.Open();
            Paragraph p = new Paragraph(text);
            doc.Add(p);
            doc.Close();
            return true;
        }
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace BookConverter
{
    class PdfAdaptee
    {
        
>>>>>>> master
    }
}
