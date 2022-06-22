using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Length of time
namespace timespan
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating timespan object
            var timeSpan = new TimeSpan(1, 2, 3); // hour, minute, seconds
            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timespan2 = TimeSpan.FromHours(1); // More readable than TimeSpan(1, 0, 0)

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration: " + duration);

            // Properties
            Console.WriteLine("Minutes: " + timeSpan.Minutes);
            Console.WriteLine("Total Minutes: " + timeSpan.TotalHours);

            // Add (Enumerable means you can't change the values)
            Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Subtract Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            // ToString (To convert TimeSpan to string we simply used this method)
            Console.WriteLine("ToString " + timeSpan.ToString()); //IF we are not using console.WriteLine simply used .ToString()

            // Parse
            Console.WriteLine("Parse " + TimeSpan.Parse("01:02:03"));
        }
    }
}
