using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tips: Never used a magic number, try to use a constant

            const int passwordLength = 10;
            int min = 97;
            int max = 120;
            // Store this results in an array and then create a string based on that array
            char[] buffer = new char[passwordLength]; // 10 Random character
            var random = new Random();
            for (var i = 0; i < passwordLength; i++)
                //Console.WriteLine((char) random.Next(min,max)); //random.Next(min, max)
                buffer[i] = (char)('a' + random.Next(min, max)); // Store it in a buffer

            //var password = ""; // This is the usually way to create new string
            var password = new string(buffer); // Create a string based on that character array

            Console.WriteLine(password);
            //
                    //Console.WriteLine((int) 'z'); // Computer only understand numbers not character
            // ASCII, american standard code for international numerical code
        }
    }
}
