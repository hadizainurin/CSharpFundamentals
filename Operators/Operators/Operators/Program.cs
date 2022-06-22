using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Here is a multiline comment
             * Not that its matter because ctrl + K & ctrl + C
             * Use comment only whys, hows, constrains, etc. not the whats.
             */
            var a = 10;
            var b = 3;
            var c = 2;
            // !() --> NOT Gate
            //Console.WriteLine(!(a != b)); // Operators Precedented 
            Console.WriteLine(b > a && a > c); // !( !) --> ==
        }
    }
}
