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
        private int _currentPosition = 0;
        public LinkedInIterator(LinkedIn linkedIn)
        {
            this.linkedIn = linkedIn;
        }
        public Profile CurrentProfile()
        {
            if (_currentPosition < linkedIn.Count)
                return linkedIn[_currentPosition];
            else
                return null;
        }

        public Profile First()
        {
            _currentPosition = 0;
            return CurrentProfile();
        }

        public bool IsDone()
        {
            return _currentPosition >= linkedIn.Count;
        }

        public Profile Next()
        {
            _currentPosition++;
            return CurrentProfile();
        }
    }
}
