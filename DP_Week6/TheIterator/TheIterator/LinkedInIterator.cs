using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheIterator
{
    class LinkedInIterator : IProfileIterator
    {
        private LinkedIn _linkedIn;
        private int _current;
        public LinkedInIterator(LinkedIn LinkedIn)
        {
            _linkedIn = LinkedIn;
            _current = 0;
        }

        public Profile CurrentProfile()
        {
            return _linkedIn[_current];
        }

        public Profile First()
        {
            _current = 0;
            return _linkedIn[0];
        }

        public bool IsDone()
        {
            return _current >= _linkedIn.Count;
        }

        public Profile Next()
        {
            ++_current;
            if (IsDone())
                return null;
            else
                return CurrentProfile();
        }

        /*public void Reset()
        {
            _current = -1;
        }*/
    }
}
