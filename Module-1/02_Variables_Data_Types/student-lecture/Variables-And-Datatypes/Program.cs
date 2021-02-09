using System;
using System.Diagnostics;

namespace Variables_And_Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            /* VARIABLES & DATA TYPES */

            /*
		    1. Create a variable to hold an int and call it numberOfExercises.
			Then set it to 26.
		    */
            int numberOfExercises;
<<<<<<< HEAD
            numberOfExercises = 26;
            Console.WriteLine(numberOfExercises);

=======
            numberOfExercises = 1;
            Console.WriteLine(numberOfExercises);
            
>>>>>>> 2a35320594bb288d1ed7d189c85c5727f0bfcad4
            /*
            2. Create a variable to hold a double and call it half.
                Set it to 0.5.
            */
<<<<<<< HEAD
            double half;
            half = .5;


=======
            double half = .5;
>>>>>>> 2a35320594bb288d1ed7d189c85c5727f0bfcad4
            Console.WriteLine(half);

            /*
            3. Create a variable to hold a string and call it name.
                Set it to "TechElevator".
            */
<<<<<<< HEAD
            string name;
            name = "techElevator";

=======
            string name = "TechElevator";
>>>>>>> 2a35320594bb288d1ed7d189c85c5727f0bfcad4
            Console.WriteLine(name);

            /*
            4. Create a variable called seasonsOfFirefly and set it to 1.
            */
            int seasonsOfFirefly = 1;
<<<<<<< HEAD

=======
>>>>>>> 2a35320594bb288d1ed7d189c85c5727f0bfcad4
            Console.WriteLine(seasonsOfFirefly);

            /*
            5. Create a variable called myFavoriteLanguage and set it to "C#".
            */
            string myFavoriteLanguage = "C#";
<<<<<<< HEAD

=======
>>>>>>> 2a35320594bb288d1ed7d189c85c5727f0bfcad4
            Console.WriteLine(myFavoriteLanguage);

            /*
            6. Create a variable called pi and set it to 3.1416.
            */
            double pi = 3.1416;
<<<<<<< HEAD

=======
>>>>>>> 2a35320594bb288d1ed7d189c85c5727f0bfcad4
            Console.WriteLine(pi);

            /*
            7. Create and set a variable that holds your name.
            */
<<<<<<< HEAD
            string myName = "Mike";
            Console.WriteLine(myName);
=======
            string myName = "Ben";
>>>>>>> 2a35320594bb288d1ed7d189c85c5727f0bfcad4

            /*
            8. Create and set a variable that holds the number of buttons on your mouse.
            */
            int numberOfMouseButtons = 3;
<<<<<<< HEAD
            Console.WriteLine(numberOfMouseButtons);
=======
>>>>>>> 2a35320594bb288d1ed7d189c85c5727f0bfcad4

            /*
            9. Create and set a variable that holds the percentage of battery left on
            your phone.
            */
<<<<<<< HEAD
            

=======
            int batteryLife = 3;
>>>>>>> 2a35320594bb288d1ed7d189c85c5727f0bfcad4


            /* EXPRESSIONS */

            /*
            10. Create an int variable that holds the difference between 121 and 27.
            */
<<<<<<< HEAD
            int difference = 121 - 27;
            Console.WriteLine(difference);
=======
            int diff10 = 121 - 27;
            Console.WriteLine(diff10);
>>>>>>> 2a35320594bb288d1ed7d189c85c5727f0bfcad4

            /*
            11. Create a double that holds the addition of 12.3 and 32.1.
            */
<<<<<<< HEAD
            double sum = 12.3 + 32.1;
            Console.WriteLine(sum);

=======
            double addition11 = 12.3 + 32.1;
            Console.WriteLine(addition11);
            
>>>>>>> 2a35320594bb288d1ed7d189c85c5727f0bfcad4

            /*
            12. Create a string that holds your full name.
            */
<<<<<<< HEAD
            myName = "Clayton Cross";


=======
            string myFullName = "Ben Kennedy";
            Console.WriteLine(myFullName);
>>>>>>> 2a35320594bb288d1ed7d189c85c5727f0bfcad4
            /*
            13. Create a string that holds the word "Hello, " concatenated onto your
            name from above.
            */
            string greeting = "Hello, " + myName;
            Console.WriteLine(greeting);

            /*
            14. Add a " Esquire" onto the end of your full name and save it back to
            the same variable.
            */
<<<<<<< HEAD
             greeting = greeting + " Esquire";
            Console.WriteLine(greeting);

            int age = 25;
             age = age + 1;
            Console.WriteLine(age);
=======
            greeting = greeting + " Esquire";
            Console.WriteLine(greeting);

>>>>>>> 2a35320594bb288d1ed7d189c85c5727f0bfcad4

            /*
            15. Now do the same as exercise 14, but use the += operator.
            */
<<<<<<< HEAD
            greeting += " all around good guy";
            age += 1;

            Console.WriteLine(greeting + ", age " + age);
=======
            greeting += " Esquire";
>>>>>>> 2a35320594bb288d1ed7d189c85c5727f0bfcad4

            /*
            16. Create a variable to hold "Saw" and add a 2 onto the end of it.
            */
<<<<<<< HEAD
            string saw = "Saw";
            saw += 2;
            Console.WriteLine(saw);

=======
            string movie = "Saw" + 2;
            Console.WriteLine(movie);
>>>>>>> 2a35320594bb288d1ed7d189c85c5727f0bfcad4
            /*
            17. Add a 0 onto the end of the variable from exercise 16.
            */

            /*
            18. What is 4.4 divided by 2.2?
            */
            Console.WriteLine( 4.4 / 2.2);

            /*
            19. What is 5.4 divided by 2?
            */
            Console.WriteLine( 5.4 / 2);

            /* CASTING */

            /*
            20. What is 5 divided by 2?
            */
            Console.WriteLine( 5 / 2);

            /*
            21. What is 5.0 divided by 2?
            */
            Console.WriteLine( 5.0 / 2);

            /*
            22. Create a variable that holds a bank balance with the value of 1234.56.
            */
            decimal balance = 1234.56M;
            Console.WriteLine(balance);

            // A second way to get a double into a decimal
            decimal myBal = (decimal) 1234.56;
            Console.WriteLine(myBal);

            /*
            23. If I divide 5 by 2, what's my remainder?
            */
            Console.WriteLine(5 % 2);


            /*
            24. Create two variables: 3 and 1,000,000,000 and multiple them together. 
                What is the result?
            */
            int multiplicand = 3;
            int multiplier = 1000000000;
            long product = multiplicand * (long)multiplier;
            Console.WriteLine(product);

            /*
            25. Create a variable that holds a boolean called doneWithExercises and
            set it to false.
            */
            bool doneWithExercises = false;


            /*
            26. Now set doneWithExercise to true.
            */
            doneWithExercises = true;
            Console.WriteLine(doneWithExercises);




        }
    }
}
