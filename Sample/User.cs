﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Sample
{
    class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public User(string name)
        {
            Name = name;
        }
    }
}
