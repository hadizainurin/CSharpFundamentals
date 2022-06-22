using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebuggingProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Breakpoint = F9 or click at the left
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6 }; // We need to get the list of the smallest number
            var smallests = GetSmallests(numbers, 3);
            foreach (var number in smallests)
                Console.WriteLine(number); // We got a bug here? We only return the largest, whats wrong?
        }

        //Lets look at this method
        public static List<int> GetSmallests(List<int> list, int count)
        {
            var smallests = new List<int>(); // Define a list to hold this smallest number

            while (smallests.Count < count) // As long as the element is less than the count, it will run this logic
            {
                var min = GetSmallest(list); //We expected this method to return the minimum number
                smallests.Add(min); // We add the min number to a new list that consists of small number
                list.Remove(min); // We remove the min number from the original list
            }

            return smallests;
        }

        public static int GetSmallest(List<int> list)
        {
            // Assume the girst number is the smallest
            var min = list[0];
            for (var i = 1; i < list.Count; i++)
            {
                if (list[i] > min)
                    min = list[i];
            }
            return min
        }
    }
}
