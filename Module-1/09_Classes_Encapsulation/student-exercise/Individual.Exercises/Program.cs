using System;

namespace Individual.Exercises.Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevator elevator1 = new Elevator(10);
            Elevator elevator2 = new Elevator(20, 200);

            Console.WriteLine($"Num floors of the first elevator : {elevator1.NumberOfLevels}");
            Console.WriteLine($"Num floors of the second elevator:{elevator2.NumberOfLevels}");

            elevator1.OpenDoor();
            
        }
    }
}
