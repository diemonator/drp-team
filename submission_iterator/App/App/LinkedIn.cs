using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class LinkedIn : ISocialNetwork
    {
        private Profile[] profiles;

        public LinkedIn()
        {
            profiles = new Profile[]
            {
                new Profile("linkedEmil","emil@abv.bg"),
                new Profile("notlinkedMrunal","m@gmail.com")
            };
        }

        public int Count
        {
            get { return profiles.Length; }
        }

        public Profile this[int index]
        {
            get { return profiles[index]; }
            set { profiles[++index] = value; }
        }

        public IProfileIterator CreateIterator()
        {
            return new LinkedInIterator(this);
        }
    }
}
