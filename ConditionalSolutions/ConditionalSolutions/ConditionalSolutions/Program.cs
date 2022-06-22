using System;

namespace ConditionalSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program and ask the user to enter a number.
            //The number should be between 1 to 10. If the user enters a valid number, display "Valid" on the console.
            //Otherwise, display "Invalid".
            //(This logic is used a lot in applications where values entered into input boxes need to be validated.)
            //var number = 11;
            //if (number > 1 && number < 10)
            //{
            //    Console.WriteLine("Valid");
            //}
            //else
            //    Console.WriteLine("Invalid");

            /// <summary>
            /// Write a program and ask the user to enter a number. The number should be between 1 to 10. If the user enters 
            /// a valid number, display "Valid" on the console. Otherwise, display "Invalid". (This logic is used a lot in 
            /// applications where values entered into input boxes need to be validated.)
            /// </summary>

            Console.Write("Please enter a number between 1 to 10: ");
            var input = Console.ReadLine();
            var number = Convert.ToInt32(input);
            if (number >= 1 && number <= 10)
                Console.WriteLine("Valid \n");
            else
                Console.WriteLine("Invalid \n");

            /// <summary>
            /// Write a program which takes two numbers from the console and displays the maximum of the two.
            /// </summary>

            Console.Write("This program will determine the max value \n");
            Console.Write("Please enter a number: ");
            var number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another number: ");
            var number2 = Convert.ToInt32(Console.ReadLine());
            var max = (number1 > number2) ? number1 : number2;
            Console.WriteLine("Max is " + max + "\n");
        }
    }
}
