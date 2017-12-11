using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchmarkDemo
{
    public class TestBenchmark
    {
        [Benchmark]
        public void StringFormatWithString()
        {
            for (int i = 0; i < 1000; i++)
            {
                Trace.WriteLine(string.Format("i = {0}", i.ToString()));
            }
        }

        [Benchmark]
        public void StringFormatWithInt()
        {
            for (int i = 0; i < 1000; i++)
            {
                Trace.WriteLine(string.Format("i = {0}", i));
            }
        }
    }
}
