using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            //1. Creating an array of integers
            int[] scores = new int[4];
            scores[0] = 99;
            scores[1] = 67;
            scores[2] = 78;
            scores[3] = 88;

            // How may elements are in the array?
            Console.WriteLine("There are" + scores.Length + " elements in the array");
            // aside... string interpolution



            //2. Creating an array of strings
            string[] students = new string[] { "DEjan", "Andrew," "Brandon," "Kameron" };



            //3. Create an array of characters that hold "Tech Elevator"
            char[] charachters = new char[] { 'T', 'e', 'c', 'h' };


            //4. Print out the first item in each array
            Console.WriteLine($"The first element is {charachters[0]);

            //5. Print out the 3rd item in each array

            //6. Get the length of each array

            //7. Get the last index 

            //8. Update the last item in each array

            Console.ReadLine();
        }
    }
}
