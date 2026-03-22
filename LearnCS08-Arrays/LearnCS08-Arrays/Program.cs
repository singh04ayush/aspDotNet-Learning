using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCS08_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num1 = new int[4];

            int[] num2 = new int[] { 1, 2, 3, 4, 5 };

            int[] num3 = { 1, 2, 3 };

            var num4 = new[] { 1, 2, 3, 4 };  // type inferred as int[] using new keyword

            // same with any datatype or string

            string[] names = new string[] { "John", "Jane", "Doe" };
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };



            // Arrays Printing And Sorting
            int[] numbers = new int[] { 5, 2, 1, 7, 5 };

            foreach (int num in numbers)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
            Array.Sort(numbers);   // returns void, sorts the array in place, no new array
            foreach (int num in numbers)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();


            // testing
            // int[] test = new int[5] { 1, 2, 3 };   failed

            // Reverse the array
            Array.Reverse(numbers);
            foreach (int num in numbers)
            {
                Console.Write($"{num} ");
            }
        }
    }
}
