using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte b = 1; // 1 byte
            //int i = b; // 4 byte
            //Console.WriteLine(i);
            //int i = 200; // There is data loss because 1000 is more than byte sie
            //byte b = (byte) i; // Can't convert source type ... Need to cast
            //Console.WriteLine(b);
            //var number = "1234";
            ////int i = (int)number; // Can't case string to int 
            //int i = Convert.ToInt32(number);
            //Console.WriteLine(i);

            //// Noted: a wrong conversion like 1234 to a byte (Convert.ToByte)
            //// the application will crash because it does not have enough storage
            //try
            //{
            // var number = "1234";
            // byte b = Convert.ToByte(number);
            // Console.WriteLine(b);
            //} // This will prevent our application from crashing
            //catch (Exception) // Exception will propagate to .Net runtime and this cause its to crash without exception handling
            //{
            //    Console.WriteLine("You trying to overfeed me?");

            //    //throw; This will crash the application and throw exception
            //}

            // Solve it by using try catch (exception) method

            try
            {
                string str = "NoDeal";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);
            }
            catch (Exception)
            {
                Console.WriteLine("Not a boolean keyword");
                throw;
            }
        }
    }
}
