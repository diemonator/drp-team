using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class FacebookIterator : IProfileIterator
    {
        private Facebook facebook;
        private int currentPosition = 0;
        public FacebookIterator(Facebook fb)
        {
            facebook = fb;
        }
        public Profile CurrentProfile()
        {
            if (currentPosition < facebook.Count)
                return facebook[currentPosition];
            else
                return null;
        }

        public Profile First()
        {
            currentPosition = 0;
            return CurrentProfile();
        }

        public bool IsDone()
        {
            return currentPosition >= facebook.Count;
        }

        public Profile Next()
        {
            currentPosition++;
            if (IsDone())
                return null;
            else
                return CurrentProfile();
        }
    }
}
