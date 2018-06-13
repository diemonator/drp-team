using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Iterator
{
    interface ISocialNetwork
    {
        IProfileIterator CreateIterator();

        int Count { get; }

        Profile this[int index] { get; set; }
    }
}
