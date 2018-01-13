using System;

namespace Types
{

    class GreetingString
    {
        public string text;

        public GreetingString()
        {
            text = "Hello Dev Ramp-Up!";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int i = 5;
            var j = 5;
            // j = "hello"; not work

            GreetingString greet1 = new GreetingString();
            string greet2 = "Hello Dev Ramp-Up!";

            ModifyGreeting(greet1);
            PrintLineBreaks(1);
            Console.WriteLine("Printing greet object value in Main method");
            Console.WriteLine(greet1.text);

            PrintLineBreaks(2);

            ModifyGreeting(greet2);
            PrintLineBreaks(1);
            Console.WriteLine("Printing local variable greet");
            Console.WriteLine(greet2);
        }

        static void ModifyGreeting(GreetingString temp)
        {
            temp.text = temp.text.ToUpper();
            Console.WriteLine("Printing greet object value in function");
            Console.WriteLine(temp.text);
        }

        static void PrintLineBreaks(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
            }
        }

        static void ModifyGreeting(string temp)
        {
            temp = temp.ToUpper();
            Console.WriteLine("Printing greet object value in function");
            Console.WriteLine(temp);
        }

    }
}