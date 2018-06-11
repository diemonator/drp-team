using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheIterator
{
    abstract class SocialNetwork
    {
        protected List<Profile> Profiles { get; set; }

        public abstract IProfileIterator CreateIterator();

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
