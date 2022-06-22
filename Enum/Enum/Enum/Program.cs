using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum2
{
    public enum ShippingMethod
    {
        RegularAirMail = 1, // 0 + 1 (Default value) or you can explicit stated the number
        RegisteredAirMail = 2, // 1 + 1
        Express = 3 // 2
    }
    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);// We could cascade its to int, Situation where we required to find the ID

            var methodId = 3; // What if you receive a number and we need to convert it to a shipping method in our apps?
            Console.WriteLine((ShippingMethod)methodId); // Cascade method of the methodID

            Console.WriteLine(method.ToString()); // CW Will convert that method to string even without ToString()

     

            // Convert string to enum ? We have string somewhere in another system

            var methodName = "Express";
            // Parsing = Convert string to different type
            var shippingMethod = (ShippingMethod) Enum.Parse(typeof(ShippingMethod), methodName); // Convert a string to enum
        }
    }
}
