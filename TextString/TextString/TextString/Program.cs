using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextString
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Abdul Hadi "; // Noted String is not modified 
            Console.WriteLine("Trim: '{0}'", fullName.Trim()); // Remove whitespace of the string (this is for comparison to work)
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper()); // Remove whitespace of the string (this is for comparison to work)

            // Split the string to first name and last name based on the index of white space
            var index = fullName.IndexOf(' '); // white space character
            var firstName = fullName.Substring(0, index); // Start at 0 and length of index of space
            var lastName = fullName.Substring(index + 1); // This start at index and all the way to the end of a string
            Console.WriteLine("FirstName: " + firstName);
            Console.WriteLine("LastName: " + lastName);

            var names = fullName.Split(' '); // Easier method
            Console.WriteLine("FirstName: " + names[0]);
            Console.WriteLine("LastName: " + names[1]);

            // Replacing name
            
            Console.WriteLine(fullName.Replace("Abdul", "Moshfegh"));

            // Empty string or NULL
            // In a real-world application, we want to see whether the user write something or not
            // How do we validate its?

            // Old method introduced by Microsoft
            if (String.IsNullOrEmpty(" ".Trim())) // Either "" or nothing but does not solve " " issue but can be solved by .Trim() method
                Console.WriteLine("Invalid");

            // New method that solve that previous problem
            if (String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid");

            // Convert string to number
            var str = "25";
            var age = Convert.ToByte(str); // Convert string to int or Byte (since no one is going to pass 200 years old age
            Console.WriteLine(age);

            float price = 29.95f;
            //price.ToString("C"); // This method is available everywhere
            Console.WriteLine(price.ToString("C"));
        }
    }
}
