using System;

namespace LinearConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the length?");
            string length = Console.ReadLine();

            Console.WriteLine("Is the measurement in (f)eet or (m)eters?");
            string measurement = Console.ReadLine();

            if(measurement == "f")
            {
               double conversion = double.Parse(length) * 0.3048;
                Console.WriteLine(length + "f is " + conversion + " in meters");
            }
            else if(measurement == "m")
            {
                double conversion = double.Parse(length) * 3.2808399;
                Console.WriteLine(length + "m is " + conversion + " in feet");
            }

        }
    }
}
