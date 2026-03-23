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
            Console.WriteLine();


            // clearning the array
            // it means setting all the elements of the array to their default value based on the type of array
            // it takes three arguments - the array, starting index, and number of elements to clear from the starting index
            Array.Clear(numbers, 0, numbers.Length); // clears the whole array
            foreach (int num in numbers)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
            Array.Clear(num2, 3, 2);
            // Array.Clear(num2, 3, 4);  out of bounds index exception 
            foreach (int n in num2)
            {
                Console.Write($"{n} ");
            }
            Console.WriteLine();
            // Clear function is same as below code
            int[] test = new int[] { 10, 20, 30, 40 };
            for (int i = 0; i < test.Length; i++)
            {
                test[i] = default;
            }
            foreach (int subj in test)
            {
                Console.Write($"{subj} ");
            }
            Console.WriteLine();




            // indexof
            int[] game = new int[] { 12, 35, 2, 55, 2, 4, 145, 4 };
            Console.Write("Enter the number to be searched: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int toSearch))
            {
                int position = Array.IndexOf(game, toSearch); // first occurrence of the number searching the entire array, returns -1 if not found
                // int position  = Array.IndexOf(game, toSearch, 3);  // searching starts from index 3 to end of the array, returns -1 if not found
                // int position  = Array.IndexOf(game, toSearch, 2, 4);  // searching starts from index 2 to index 5 (2+4-1) of the array, returns -1 if not found
                if (position > -1)
                {
                    Console.WriteLine($"The number {toSearch} first position has been found at {position}");
                }
                else
                {
                    Console.WriteLine($"The number {toSearch} was not found");
                }
            }

            // similarly LastIndexOf(array, toSearch, startIndex, count) -> return index based on forward zero-indexing and -1 if not found, but searching the array backwardsk
            // int lastPosition = Array.LastIndexOf(game, toSearch, 3, 1);  // startIndex → the position in the array where the search begins. 
            // int lastPosition = Array.LastIndexOf(game, toSearch, 4);     // count → how many elements (going backwards) to include in the search.
            int lastPosition = Array.LastIndexOf(game, toSearch);  // last occurrence of the number searching the array backwards, returns -1 if not found and same with variants
            
            if (lastPosition > -1)
            {
                Console.WriteLine($"The number {toSearch} last position has been found at {lastPosition}");
            }
            else
            {
                Console.WriteLine($"The number {toSearch} was not found");

            }




        }
    }
}
