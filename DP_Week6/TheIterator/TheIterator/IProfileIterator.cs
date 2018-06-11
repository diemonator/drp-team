using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheIterator
{
    interface IProfileIterator
    {
        //void Reset();
        Profile First();
        Profile Next();
        Profile CurrentProfile();
        bool IsDone();
    }
}
