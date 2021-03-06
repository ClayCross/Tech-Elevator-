using System;

namespace Lecture
{
    class Program
    {
        static bool sticky1(bool a) {
            Console.WriteLine("in sticky1");
            return a;
        }
        static bool sticky2(bool b) {
            Console.WriteLine("in sticky2");
            return b;
        }
        static bool sticky3(bool c) {
            Console.WriteLine("in sticky3");
            return c;
        }
        static void Main(string[] args)
        {
            bool a = true;
            bool b = true;
            bool c = true;
            if (sticky1(a) && sticky2(b) || sticky3(c)) {
                Console.WriteLine("in IF");
            }
            Console.WriteLine("done");
            /*****************************************************************************
            Part 1: Variable Scope
            ******************************************************************************/
            // Declare a variable
            int outerVariable = 100;
            Console.WriteLine("Outervariable is " + outerVariable);
            // Start a statement block
            {
                
                // Print out the variable defined in the outer scope
                Console.WriteLine("Outervariable (from the inner block) = " +outerVariable);

                outerVariable += 1000;

                // Declare a variable in the block (inner scope)
                int innerVar = 200;





                // Print out that variable
                Console.WriteLine("InnerVar is " + innerVar);

                // End the statement block
            }

            // Print the the variable declared in the block
            // OOPS I cannot do this...
            Console.WriteLine("Outervariable is " + outerVariable);


            /*****************************************************************************
            Part 2: Methods
            ******************************************************************************/
            // Call the MultiplyBy method
            // I have a 10 x 12 room. Calcualate its area using MultipleTwoNumbers

            int length = 12;
            int width = 10;
            int area = MultiplyTwoNumbers(length, width);
            Console.WriteLine("The are of the room is " + area);

            // Create and print some boolean expressions

            int age = 23;

            if (age >= 18)
            {
                Console.WriteLine("You are an adult");
            }
            else
            {
                Console.WriteLine("You are just a kid");
            }


                Console.WriteLine("This is the end");



        }

        /*
         * Create a method called MultiplyBy, which takes two integers and returns the integer product.
         */
          static int MultiplyTwoNumbers(int a, int b)
        {
            int product = a * b;
            return product;
        }
    }
}
