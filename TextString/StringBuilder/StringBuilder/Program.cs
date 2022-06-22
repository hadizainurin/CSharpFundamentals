using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// StringBuilder make it faster to manipulate string
// Stringbuilder make program more efficient than manipulating an enumerable string
namespace StringBuilderNameSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder("Hello World");// 
            
            // Noted you can also do example builder.Append but below method is cleaner
            builder
                .Append('-', 10) // This return a string builder which means we can change this append method
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10) // This make the code less noisy
                .Replace('-', '+')
                .Remove(0, 10);

            builder.Insert(0, new string('-', 10));

            Console.WriteLine(builder);

            // Access invidiual string just like a character using index

            Console.WriteLine("First Char: " + builder[0]);
        }
    }
}
