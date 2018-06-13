using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Facebook : ISocialNetwork
    {
        private List<Profile> profiles;

        public Facebook()
        {
            profiles = new List<Profile>()
            {
                new Profile("Emil","emil@abv.bg"),
                new Profile("Mrunal","m@gmail.com"),
                new Profile("John","j@gmail.com"),
                new Profile("Alex","a@gmail.com"),
            };
        }

        public int Count
        {
            get { return profiles.Count; }
        }

        public Profile this[int index]
        {
            get { return profiles[index]; }
            set { profiles.Add(value); }
        }

        public IProfileIterator CreateIterator()
        {
            return new FacebookIterator(this);
        }
    }
}
