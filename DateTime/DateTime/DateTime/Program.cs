using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2015, 1, 1); // year, month, day
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine("Specific Date: " + dateTime);
            Console.WriteLine("Today Date: " + today);
            Console.WriteLine("Now Time and Date: " + now);
            Console.WriteLine("Hour: " + now.Hour);
            Console.WriteLine("Minute: " + now.Minute);

            var tomorrow = now.AddDays(1); //Move one day forward
            var yesterday = now.AddDays(-1); // Move one day backward

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm")); // C# datetime format specifier

        }
    }
}
