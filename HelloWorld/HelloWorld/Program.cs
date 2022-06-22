using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; // multithreading application

namespace HelloWorld
{
    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(); // Let the compiler know Person person (var let it knows)
            person.Name = "John";
            person.Introduce("Mosh");
        }
    }
}
