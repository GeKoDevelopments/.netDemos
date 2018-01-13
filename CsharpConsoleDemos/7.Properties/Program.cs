using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            TimePeriod t = new TimePeriod();

            t.Hours = 24;
            Console.WriteLine("Time in hours: " + t.Hours);

            // Static fields
            Console.WriteLine(TimePeriod.static_member);
            // t.static_member ++; not working
            TimePeriod.static_member++;
            Console.WriteLine(TimePeriod.static_member);
        }

        class TimePeriod
        {
            private double seconds;
            public double Hours
            {
                get { return seconds / 3600; }
                set { seconds = value * 3600; }
            }

            public static int static_member = 10;
        }
    }
}
