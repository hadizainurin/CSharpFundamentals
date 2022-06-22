using Classes.Math;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Tips ctrl + tab
namespace Classes
{
    class Program // Alt + Enter --> Move to Person.cs
        {
            static void Main(string[] args)
            {
                var abdul = new Person();
                abdul.FirstName = "Abdul";
                abdul.LastName = "Hadi";
                abdul.Introduce();

            Calculator calculate = new Calculator();
            var result = calculate.Add(1, 2);
            System.Console.WriteLine(result); //All methods in console are considered static
        }
      
        }
}
