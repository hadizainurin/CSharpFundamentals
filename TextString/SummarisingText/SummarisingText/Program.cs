using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// To improve the reusebalitiy of the method, put a class in a different program
// Real-world application,
namespace SummarisingText
{
    // You see a summary from blog page and you want to make its cleaner. How do you do it?
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "Really really really long test";
            var summary = StringUtility.SummerizeText(sentence, 30); // Notice that StringUtility class can't be accessed
            // because we did not declare its public 
            Console.WriteLine(summary);
        }
        // Practice: do not hardcode if you can avoided it
        // This used to have other
    }
}
