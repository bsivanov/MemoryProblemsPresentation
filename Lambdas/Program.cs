using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambdas
{
    class Program
    {
        private static Dictionary<string, string> myCache = new Dictionary<string, string>();

        private static string GetOrCreate(string key, Func<string> evaluator)
        {
            string result;
            if (myCache.TryGetValue(key, out result))
            {
                return result;
            }

            result = evaluator();;
            myCache[key] = result;
            return result;
        }

        public static string Substring(string x)
        {
            var ret = GetOrCreate(x, () => x.Substring(1));
            return ret;
        }

        static void Main(string[] args)
        {
            string[] strings = { ".exe", ".png", ".jpg" };

            for (int i = 0; i < int.MaxValue; i++)
            {
                Console.WriteLine(Substring(strings[i % 3]));
            }
        }
    }
}
