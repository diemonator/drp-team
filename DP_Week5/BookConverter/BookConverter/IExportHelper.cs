using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookConverter
{
    interface IExportHelper
    {
        bool Export(string path, Library library);
    }
}
