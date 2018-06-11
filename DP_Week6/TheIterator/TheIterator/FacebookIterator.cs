using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheIterator
{
    class FacebookIterator : IProfileIterator
    {
        private Facebook _facebook;
        private int _current = 0;
        public FacebookIterator(Facebook facebook)
        {
            _facebook = facebook;
        }

        public Profile CurrentProfile()
        {
            return _facebook[_current];
        }

        public Profile First()
        {
            _current = 0;
            return _facebook[0];
        }

        public bool IsDone()
        {
            return _current >= _facebook.Count;
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
