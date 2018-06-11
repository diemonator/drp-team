using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheIterator
{
    class Facebook : SocialNetwork
    {
        public Facebook()
        {
            Profiles = new List<Profile>()
            {
                new Profile("Emil","emil@abv.bg"),
                new Profile("Gosho","gosho@abv.bg"),
            };
        }

        public override IProfileIterator CreateIterator()
        {
            return new FacebookIterator(this);
        }
    }
}
