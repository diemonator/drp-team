using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Iterator
{
    interface IProfileIterator
    {
        Profile First();
        Profile Next();
        bool IsDone();
        Profile CurrentProfile();
    }
}
