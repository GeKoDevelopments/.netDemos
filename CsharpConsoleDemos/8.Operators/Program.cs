using System;

namespace Operators
{
    class Program
    {

        static void Main(string[] args)
        {
            Month Jan = new Month(31);
            Month Feb = new Month(28);
            Console.WriteLine("Finding if Jan has more days than February using Operator overloading");
            if (Jan > Feb)
                Console.WriteLine("Jan has more days than Feb");
            else
                Console.WriteLine("Feb has more days than Jan");
        }
    }

    class Month
    {
        public int daysInMonth;

        public Month(int val)
        {
            daysInMonth = val;
        }

        public static bool operator >(Month param1, Month param2)
        {
            if (param1.daysInMonth > param2.daysInMonth)
                return true;
            else
                return false;
        }

        public static bool operator <(Month param1, Month param2)
        {
            if (param1.daysInMonth < param2.daysInMonth)
                return true;
            else
                return false;
        }
    }



}
