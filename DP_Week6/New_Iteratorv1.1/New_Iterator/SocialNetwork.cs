using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Iterator
{
    abstract class SocialNetwork
    {
        protected abstract IProfileIterator CreateIterator();
        protected abstract List<Profile> Profiles { get; set; }
        public int Count
        {
            get { return Profiles.Count; }
        }

        public Profile this[int index]
        {
            get { return Profiles[index]; }
            set { Profiles.Add(value); }
        }

    }
}
