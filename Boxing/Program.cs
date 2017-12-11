using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 1000000; i++)
            {
                Trace.WriteLine(string.Format("i = {0}", i.ToString()));
            }
        }
    }
}
