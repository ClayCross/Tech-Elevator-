using System;
using System.IO;

namespace WordSearch
{
    class Program
    {
        

       
        public static String word;
        public static String file;
        public static bool UpperOrLower = false; 

        static void Main(string[] args)
        {
            Console.WriteLine("What's the name of the file?");
            string file = Console.ReadLine();

            Console.WriteLine("What's the word you're looking for? ");
            string word = Console.ReadLine();

            Console.WriteLine("Should it be case sensitive? (Y\\N)");
            bool UpperOrLower = (Console.ReadLine().ToLower() == "y");

            
            string path = @"..\..\..\..\alices_adventures_in_wonderland.txt";


            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    int i = 1;
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        bool HasWord = (!UpperOrLower && line.IndexOf(word, StringComparison.CurrentCultureIgnoreCase) > 0) ||
                            line.IndexOf(word) > 0;

                        if (HasWord)
                        {
                            Console.WriteLine($"{i}) {line}");
                        }

                        i++;
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error");
               
               
            }

            Console.ReadLine();

        }
    }
}