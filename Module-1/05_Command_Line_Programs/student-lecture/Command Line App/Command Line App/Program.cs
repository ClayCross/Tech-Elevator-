using System;

namespace Command_Line_App
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Hello, what is your name!");

            //// Get the users name

            //string name = Console.ReadLine();

            //// Greet the user

            //Console.WriteLine($"Well hello there, {name}!");

            //// Ask for height
            //Console.Write("How tall are you in inches? ");

            //// Read Height
            //string  heightAsString = Console.ReadLine();
            //int heightInches = int.Parse(heightAsString);

            //// calculate the height in feet and inches...
            //int feet = heightInches / 12;
            //int inches = heightInches % 12;

            //Console.WriteLine($"Wow, did you know that is {feet} feet and {inches} inches?");

            //// Ask if the user is wearing flannel
            //Console.Write("Are you wearing flannel now (true / false)?");
            //string input = Console.ReadLine();
            //bool isWearingFlannel = bool.Parse(input);



            //// If they are, and they are over 6 feet, we will tell them they look a lumberjack
            //if (isWearingFlannel)
            //{
            //    Console.WriteLine("Thanks for participating");
            //}
            //else
            //{
            //    Console.WriteLine("Maybe next week!");
            //}

            //Ask the user for a sentence
            Console.WriteLine("Enter a sentence: ");
            string sentence = Console.ReadLine();

            //Split the sentence into words, and print one word on each line
            string[] words = sentence.Split(" ");

            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
            

            

             






        }
    }
}
