using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScopePlay
{
    class Program
    {
        private static int k;

        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                k = i;
            }
            Console.ReadKey();

            Console.WriteLine("k: " + k);
        }
    }
}
