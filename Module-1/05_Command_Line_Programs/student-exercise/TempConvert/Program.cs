using System;

namespace TempConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's the current Tempature?");
            string temp = Console.ReadLine();

            Console.WriteLine("Is the temperature in (C)elsius, or (F)ahrenheit?");
            string index = Console.ReadLine();

            if (index == "C")
            {
                double conversion = double.Parse(temp) * 1.8 + 32;
                Console.WriteLine(temp + "C is " + conversion + "in fahrenheiht");
            }
            else if (index == "F")
            {
                double conversion = (double.Parse(temp) - 32) / 1.8;
                Console.WriteLine(temp + "F is " + conversion + "in celsius");
            }



        }
    }
}
