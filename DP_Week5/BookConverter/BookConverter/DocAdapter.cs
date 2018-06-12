using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookConverter
{
    class DocAdapter : IExportHelper
    {
        
        public DocAdapter()
        {

        }

        public bool Export(string path, Library library)
        {
            // library.ExportTo(path);
            return false;
        }
    }
}
