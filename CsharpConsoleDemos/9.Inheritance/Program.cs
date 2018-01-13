using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle sub = new Submarine();

            sub.PrintWheelInfo();

        }
    }

    public class Submarine : Vehicle
    {
        public override void PrintWheelInfo()
        {
            Console.WriteLine("Submarine has no wheels");
        }
    }

    public class Vehicle
    {
        public int numOfWheels;
        public string fuel;

        public void Accelerate()
        {

        }

        public virtual void PrintWheelInfo()
        {
            Console.WriteLine("This vehicle has " + numOfWheels.ToString() + "wheels");
        }
    }
}
