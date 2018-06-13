using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class LinkedInIterator : IProfileIterator
    {
        private LinkedIn linkedIn;
        private int currentPosition = 0;
        public LinkedInIterator(LinkedIn ln)
        {
            linkedIn = ln;
        }
        public Profile CurrentProfile()
        {
            if (currentPosition < linkedIn.Count)
                return linkedIn[currentPosition];
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
            return currentPosition >= linkedIn.Count;
        }

        public Profile Next()
        {
            currentPosition++;
            return CurrentProfile();
        }
    }
}
