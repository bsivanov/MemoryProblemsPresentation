﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfBindingMemoryLeak
{
    class Person
    {
        public Person(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}