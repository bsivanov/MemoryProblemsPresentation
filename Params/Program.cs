using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < int.MaxValue; i++)
            {
                Log("test", i);
            }
        }

        private static void Log(string message, params object[] arguments)
        {
            Console.WriteLine(message);
            for (int i = 0; i < arguments.Length; i++)
            {
                Console.WriteLine(arguments[i].ToString());
            }
        }
    }
}
