using System;

namespace CommandLineApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //            Console.Write("Hello, what is your name?");

            //             string name = Console.ReadLine();

            //            // Greet the user
            //            Console.WriteLine($"Well hello there, {name}");

            //            // Ask if the user is wearing flannel

            //            // If they are and they are over 6 feet we will tell them they look like a lumberjack/jill

            //            Console.Write("Are you wearing flannel right now  (true / false)?");
            //            string input = Console.ReadLine();
            //            bool isWearingFlannel = bool.Parse(input);


            //            if (isWearingFlannel)

            //                Console.WriteLine("Thanks for participating!");

            //            else
            //            {
            //                Console.WriteLine("Maybe next week!");
            //            }
            //;
            //        }
            //    }
            //}

            //Ask the user for a sentence
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();

            //Split the sentence into words, and print one word on each line
            string[] words = sentence.Split(" ");

            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
            string newSentence = string.Join("---", words);
            Console.WriteLine(newSentence);
        }
    }
}
            

