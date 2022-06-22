using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// For
// For each
// While
// Do-While

namespace IterationStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (var i = 1; i <= 10; i++)
            //{
            //    if (i%2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //var i = 0;
            //while (i <= 10)
            //{
            //    if (i % 2 == 0)
            //        Console.WriteLine(i);
            //    i++; // For loop is for when we know the number of times we want to iterates
            //}

            // Example: Write a simple echo program, if the user type their name
            // the console will write that name otherwise terminate
            // here we don't know how many times the user type their name, so we used while loop

            while(true) // This loop will execute forever
            {
                Console.Write("Type your name: "); // No line break with write vs WriteLine
                var input = Console.ReadLine(); // This method used string

                if (!String.IsNullOrWhiteSpace(input)) //If it is not Null or White Space, we get a name
                {
                    Console.WriteLine("Name: " + input); //@Echo to 
                    continue; // Go back to the beginning of loop (while)
                }
                break; // Loop is terminated
                // Two way, either you break when it is Null or white space or continue when it is not Null or white space
            }

            //for (var i = 10; i >= 1; i--)
            //    if (i%2 ==0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //var name = "John Smith"; // String is a sequence of character, an enumerable object like a list

            //for (var i = 0; i < name.Length; i++)
            //{
            //    Console.WriteLine(name[i]);
            //}

            //foreach (var character in name) // Does not need to make a comparison or increment
            //{
            //    Console.WriteLine(character); // We can access the character instead of name[i]
            //}

            //var numbers = new int[] { 1, 2, 3, 4 }; // Used object initialisation syntax to initialise the array with some number
            
            //foreach (var number in numbers) // foreach ( var int in variable)
            //{
            //    Console.WriteLine(number);
            //}

        }
    }
}
