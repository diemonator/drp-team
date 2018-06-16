﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookConverter
{
    public class Book
    {
        public string Name { get; private set; }
        public string Author { get; private set; }

        public Book(string name, string author)
        {
            Name = name;
            Author = author;
        }

        public override string ToString()
        {
            return Name + " by- " + Author;
        }
    }
}
