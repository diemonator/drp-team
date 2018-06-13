using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Iterator
{
    class Manager
    {
        Facebook facebook = new Facebook();
        LinkedIn linkedin = new LinkedIn();

        public IProfileIterator CreateIterator(ISocialNetwork social)
        {
            if (social is Facebook)
            {
                return new FacebookIterator(facebook);
            }
            else
            {
                return new LinkedInIterator(linkedin);
            }
        }

        public ISocialNetwork CreateFacebook()
        {
            return facebook;
        }
        public ISocialNetwork CreateLinkedIn()
        {
            return linkedin;
        }
    }
}
