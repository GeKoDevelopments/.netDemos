using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fibarray = { 0, 1, 1, 2, 3, 5, 8, 13 };

            // for loop
            for (int k = 0; k < fibarray.Length; k++)
            {
                Console.WriteLine(fibarray[k]);
            }
            Console.WriteLine();

            // while loop
            int j = 0;
            while (j < 5)
            {
                Console.WriteLine(fibarray[j]);
                j++;
            }
            Console.WriteLine();

            // foreach loop
            foreach (int element in fibarray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();

            // do-while loop
            int i = 0;
            do
            {
                Console.WriteLine(fibarray[i]);
                i++;
            } while (i < fibarray.Length);
        }
    }
}
