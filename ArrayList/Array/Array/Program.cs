using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Array represents a fixed number of variables of a particular type
// Single Dimension or Multi Dimensional Array
// Rectangular vs Jagged which is faster for multidimensional array?

namespace Array2
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 3, 6, 4, 2, 5, 9, 12 , 2};

            // Length - Instance member (accessible from an object)
            Console.WriteLine("Length: " + numbers.Length);

            //IndexOf() - Static method (accessible from the array class) Red X means static method form msdn
            var index = Array.IndexOf(numbers, 9); //IndexOF methods are to find the position of element in an array
            Console.WriteLine("Index of 9: " + index);

            // Clear() setting the numbers to NULL or 0
            Array.Clear(numbers, 0, 2); // from which index to what index?

            Console.WriteLine("Effect of Clear()");
            foreach (var n in numbers)
                Console.WriteLine(n);
            //var numbers = new int[5] { 1, 2, 3, 4, 5 }; //{} initialise object to known variables
            //var matrix = new int[3, 5]; // 3 rows and 5 columns
            //var colors = new int[3, 5, 4]; // 3D arrays

            // Copy() method
            int[] anotherarray = new int[3]; // Copy number from our old array to this new array
            Array.Copy(numbers, anotherarray, 3);

            Console.WriteLine("Effect of Copy()");
            foreach (var n in anotherarray)
                Console.WriteLine(n);

            // Sort()
            Array.Sort(numbers);

            Console.WriteLine("Effect of Sort()");
            foreach(var n in numbers)
                Console.WriteLine(n);

            // Reverse()
            Array.Reverse(numbers);

            Console.WriteLine("Effect of Reverse()");
            foreach (var n in numbers)
                Console.WriteLine(n);
        }
    }
}
