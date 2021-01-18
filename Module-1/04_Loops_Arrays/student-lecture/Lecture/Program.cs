using System;

namespace Lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Use a for-loop to print "Hello World" 10 times
            

            for (int i = 1; i <= 10; i = i +1)
            {
                Console.WriteLine("Hello World");
            }



            // 2. Create an array of quiz scores
            int[] scores =new int[] {92, 87, 100, 66};


            // 3. Print all the scores to the screen
            for (int i = 0; i < scores.Length; i += 1)
            {
                Console.WriteLine($"Score = {scores[i]}");
            }





            // 4. Grade on a curve...increase all scores by the curve amount
            int curveAmount = 7;
            for (int i = 0; i < scores.Length; i++)
            { }


            // 5. Calculate and print the average score for the class after the curve.

            int scoreTotal = 0;

            for ( int i = 0; i  < scores.Length; i++)
            {
                scoreTotal += scores[i];
            }
            int averageScore = scoreTotal / scores.Length;

            Console.WriteLine($"Average score is {averageScore }");

        }
    }
}
