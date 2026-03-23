using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCS_09_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dummyArray = new int[] { 12, 4, 2, 6, 4, 244, };

            // Arrays are static and cannot dynamically can not increase or decrease in size during runtime
            // For this we can use List

            List<int> numbers = new List<int>(); //1st overload,  creates an empty list
            List<int> numbers2 = new List<int>(10); // 2nd overload, creates a list with a initial capacity of 10
            List<int> number3 = new List<int>(dummyArray); // 3rd overload, creates a list and initializes it with the elements from the provided collection (dummyArray in this case)


            List<int> number4 = dummyArray.ToList(); // Another way to create a list from an array using LINQ's ToList() method
            List<int> number5 = new List<int>()
            {
                1, 2, 3, 4, 5
            };

            // LINQ
            // Language Integrated Query, is a powerful feature in C#
            // it allows you to query and manipulate data in a more readable & concise way, using a syntax that is similar to SQL (Structured Query Language)
            // These methods operate on any type that implements IEnumerable<T> or IQueryable<T>
            // examples are- 
            /*
             
            ToList()    Converts an array or IEnumerable to a List	             var list = array.ToList();
            Where()     Filters elements based on a condition	                 numbers.Where(n => n > 5)
            Select()	Projects each element into a new form	                 numbers.Select(n => n * 2)
            OrderBy()	Sorts elements in ascending order	                     numbers.OrderBy(n => n)
            GroupBy()	Groups elements by a key	                             students.GroupBy(s => s.Class)

             */




            //Methods
            List<int> mainNum = new List<int>();
            mainNum.Add(1); // Adds an element to the end of the list
            mainNum.Add(2);
            foreach (int n in mainNum)
            {
                Console.Write($"{n} ");
            }
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter a number to add: ");
                string input = Console.ReadLine();
                int.TryParse(input, out int n);
                mainNum.Add(n);
            }
            Console.Write("New list is -> ");
            foreach (int n in mainNum)
            {
                Console.Write($"{n} ");
            }
            Console.WriteLine();
            Console.Write("Enter the zero-based position of the number you wanr to remove ");
            string toRemoveinput = Console.ReadLine();
            int.TryParse(toRemoveinput, out int position);
            mainNum.RemoveAt(position); // Removes the element at the specified index
            foreach (int n in mainNum)
            {
                Console.Write($"{n} ");

            }


            // Serveral More methods are available, try to explore on your own
            mainNum.Remove(4); // Removes the first occurrence of the specified value from the list
            bool isPresent = mainNum.Contains(4);
            Console.WriteLine(isPresent);
            int currentCount = mainNum.Count;
            Console.WriteLine(currentCount);
            Console.WriteLine($"Element At index 2 is {mainNum.ElementAt(2)}");

            // similarly many methods
            // insert , clear, indexOf, lastIndexOf, reverse, sort, Find, FindAll, etc


        }
    }
}
