using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheIterator
{
    class LinkedIn : SocialNetwork
    {
        public LinkedIn()
        {
            Profiles = new List<Profile>()
            {
                new Profile("Mrunal","mrunal@gmail.com"),
                new Profile("Habibi","habibi@gmail.com")
            };
        }

        public override IProfileIterator CreateIterator()
        {
            return new LinkedInIterator(this);
        }
    }
}
