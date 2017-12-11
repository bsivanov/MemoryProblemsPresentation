using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlerMemoryLeak
{
    class Person
    {
        public Person(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public event EventHandler Sang;

    }
}
