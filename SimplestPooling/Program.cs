using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplestPooling
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < int.MaxValue; i++)
            //{
            //    BenchmarkTest.ConcatStrings("a", "b", "c");
            //}
            BenchmarkRunner.Run<BenchmarkTest>();
        }
    }

    public class BenchmarkTest
    {
        [Benchmark]
        public void NonOptimized() => ConcatStrings("a", "b", "c");

        [Benchmark]
        public void Optimized() => ConcatStringsOptimized("a", "b", "c");

        public static string ConcatStrings(string v1, string v2, string v3)
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append(v1);
            stringBuilder.Append(v2);
            stringBuilder.Append(v3);

            return stringBuilder.ToString();
        }

        private static StringBuilder stringBuilderCache;

        public static string ConcatStringsOptimized(string v1, string v2, string v3)
        {
            if (stringBuilderCache == null)
            {
                stringBuilderCache = new StringBuilder();
            }


            stringBuilderCache.Append(v1);
            stringBuilderCache.Append(v2);
            stringBuilderCache.Append(v3);

            string result = stringBuilderCache.ToString();

            stringBuilderCache.Clear();

            return result;
        }
    }
}
