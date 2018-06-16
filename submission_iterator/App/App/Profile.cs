﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Profile
    {
        public string Name { get; private set; }
        public string Email { get; private set; }

        public Profile(string name, string email)
        {
            Name = name;
            Email = email;
        }
    }
}
