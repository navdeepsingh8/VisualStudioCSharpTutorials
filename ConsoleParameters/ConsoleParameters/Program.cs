using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleParameters
{
    class Program
    {
        private static void Display(int[][] jagged)
        {
            Console.WriteLine("The elements of this array are:");
            for (int i = 0; i < jagged.Length; i++)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    Console.WriteLine("[" + (i + 1) + "][" + (j + 1) + "]:" + jagged[i][j]);
                }
            }
        }
        static void Main(string[] args)
        {
            //Clear console
            Console.Clear();
            // The Length property is used to obtain the length of the array. 
            // Notice that Length is a read-only property:
            Console.WriteLine("Number of command line parameters = {0}",
                              args.Length);
            //for (int i = 0; i < args.Length; i++)
            //{
            //    Console.WriteLine("Arg[{0}] = [{1}]", i, args[i]);
            //}

            foreach (string s in args)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Creating a jagged array..");
            int[][] jagged = { new int[] { 5, 6, 7 }, new int[] { 1, 2 } };
            //int[][] jagged = { { 1, 2, 3 }, { 5, 6 } };

            Display(jagged);

            Console.WriteLine("Reversing elements of array...");
            var jagged2 = jagged.Reverse();

            Console.WriteLine("Reversed.");
            //Display(jagged2);

        }
    }

}
