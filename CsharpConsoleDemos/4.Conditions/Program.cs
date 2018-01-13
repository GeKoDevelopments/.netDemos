using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());

            //if-else statement
            if (x > 5)
            {
                Console.WriteLine("then statement");
            }
            else
            {
                Console.WriteLine("else statement");
            }
            // Next statement in the program.


            // if statement without an else
            if (x < 5)
            {
                Console.WriteLine("then statement");
            }
            // Next statement in the program.
            switch (x)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                default:
		            Console.WriteLine("Default case");
                    break;
            }
        }
    }
}
