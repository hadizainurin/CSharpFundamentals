using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProceduralProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            // Can you convert this code to procedural way?

            Console.WriteLine("What's your name? "); // This is working with a console
            //So separate that console and logic
            var name = Console.ReadLine();
            var reversed = ReverseName(name);

            //var array = new char[name.Length];
            //for (var i = name.Length; i > 0; i--)
            //    array[name.Length - i] = name[i - 1];

            //var reversed = new string(array); // return reverse name as a string
            Console.WriteLine("Reversed name: " + reversed); // display the result on a console
        }
        // Solution

        // Extract a method or function from this logic
        // First we separate code that is work to the console and code that implement some logic

        // Line 18 used business logic on which we used an array to reverse a name
        // Noted in real-world we have different application that does not necessarily used console (console application)

        // As we are in the main method that is static, to call this method we have to make its static as well

        public static string ReverseName(string name) // We only used var name and it is string
        {
            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
                array[name.Length - i] = name[i - 1];

            //var reversed = new string(array); // This is a noise, so what coming out of this method is a reverse name

            return new string(array);
        }
    }
}
