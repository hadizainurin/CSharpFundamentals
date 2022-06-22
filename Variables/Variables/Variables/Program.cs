using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            const float Pi = 3.14f;
            //Pi = 1; // Pi already a constant

            // Noted: You can replace all the data type with var for example bye --> var, int --> var
            // This let the Visual Studio to automate the data type, but you fcan always specify its yourself
            //var number = 2; // = initalising to 2
            //var count = 10;
            //var totalPrice = 20.95f; // by adding f we declare its as float
            //var character = 'A';
            //string firstName = "Mosh";
            //var isWorking = true; // bool true/false --> true or false is a keyword just like namespace, static, void, etc.

            //Console.WriteLine(number); // Need to initialised it first
            //Console.WriteLine(count);
            //Console.WriteLine(totalPrice);
            //Console.WriteLine(character);
            //Console.WriteLine(firstName);
            //Console.WriteLine(isWorking);
            //Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue); // To see the overflow
        }
    }
}
