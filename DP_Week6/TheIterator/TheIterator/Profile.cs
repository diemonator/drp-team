using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheIterator
{
    class Profile
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Profile(string name, string email)
        {
            Name = name;
            Email = email;
        }
    }
}
