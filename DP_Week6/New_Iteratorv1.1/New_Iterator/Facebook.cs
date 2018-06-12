using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Iterator
{
    class Facebook : SocialNetwork
    {
        protected override List<Profile> Profiles { get; set; }

        public Facebook()
        {
            Profiles = new List<Profile>()
            {
                new Profile("Emil","emil@abv.bg"),
                new Profile("Mrunal","m@gmail.com"),
                new Profile("John","j@gmail.com"),
                new Profile("Alex","a@gmail.com"),
            };
        }

        protected override IProfileIterator CreateIterator()
        {
            return new FacebookIterator(this);
        }
    }
}
