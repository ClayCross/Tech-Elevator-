using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 24;
            int answer = SumTotal(num1, num2);

            {
                Console.WriteLine($"Division = {DivideInts(num1, num2)}");
                Console.WriteLine($"Product = {MultipyTotal(num1, num2)}");
                Console.WriteLine($"Sum = {answer}");
            }

        }

        public static int SumTotal(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int MultipyTotal(int n1, int n2)
        {
            return n1 * n2;
        }

        public static int DivideInts(int n1, int n2)
        {
            if (n1 == 0)
            {

            }

            return n1 / n2;
        }
        


    }
}
