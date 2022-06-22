using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Array fixed size vs List dynamic size
// What can we do with a list?
namespace ListProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1, 2, 3, 4}; // We can use object initialisation syntax if we want
            numbers.Add(1);
            numbers.AddRange(new int[3] { 5, 6, 7 }); //This is enumerable int which means we can give an array or list (different class)
        
            foreach (var number in numbers)
                Console.WriteLine(number);

            //indexOf()
            Console.WriteLine("Index of 1: " + numbers.IndexOf(1));
            Console.WriteLine("Last Index of 1: " + numbers.LastIndexOf(1));

            Console.WriteLine("Count: " + numbers.Count);
            //numbers.Remove(1); // This work but wrong logic

            for (var i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1) // iteratate the list one object at a time
                    numbers.Remove(numbers[i]);
            }
            //foreach(var number in numbers) // C# does not allow modify collection in foreach loop
            //{
            //    if (number == 1) // iteratate the list one object at a time
            //        numbers.Remove(number);
            //}
            foreach(var number in numbers) //Unhandle exception may happen when we remoe a number from a list
                Console.WriteLine(number);

            //Clear();
            numbers.Clear(); // This removes all elements from the list
        }
    }
}
