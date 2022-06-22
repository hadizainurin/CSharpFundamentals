using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndValues
{
    class Program
    {
        public class Person
        {
            public int Age;
        }
        static void Main(string[] args)
        {
            var number = 1;
            Increment(number);
            Console.WriteLine(number);

            var person = new Person() { Age = 20 };
            MakeOld(person);
            Console.WriteLine(person.Age);
        }
            public static void Increment(int number)
            {
                number += 10;
            }

            public static void MakeOld(Person person)
            {
                person.Age += 10;
            }
            // A simple demonstration of memory management difference between two types
            //var a = 10;
            //var b = a;
            //b++;
            //// Q: Value of a? ans: 10
            //// int is a value type, when value type is copy to another variable is taken and store in the target memory

            //Console.WriteLine(string.Format("a: {0}, b: {1}", a, b)); //{0} & {1} are placeholders

            //// Array is a class, therefore it is a reference type
            //var array1 = new int[3] { 1, 2, 3 };
            //var array2 = array1;
            //array2[0] = 0;
            //Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0]));
        //}
    }
}
