using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Iterator
{
    class LinkedIn : SocialNetwork
    {
        protected override List<Profile> Profiles { get; set; }

        public LinkedIn()
        {
            Profiles = new List<Profile>()
            {
                new Profile("linkedEmil","emil@abv.bg"),
                new Profile("notlinkedMrunal","m@gmail.com")
            };
        }

        protected override IProfileIterator CreateIterator()
        {
            return new LinkedInIterator(this);
        }
    }
}
