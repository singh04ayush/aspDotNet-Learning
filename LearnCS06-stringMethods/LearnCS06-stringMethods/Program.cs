using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCS06_stringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string methods

            // concat
            string name = "Ayush";
            Console.WriteLine(string.Concat(name, " Singh"));

            




            //Empty

            Console.Write("Enter a name: ");
            string input = Console.ReadLine();  // what if user doesn't enter anything and just presses enter?
            if (input != "") 
            {
                Console.WriteLine($"Name is {input}");
            } else
            {
                Console.WriteLine($"No input!!");
            }

            // the use of "" inside the if is not good and not readable
            //much better way
            Console.Write("Enter a second name: ");
            string input2 = Console.ReadLine();
            if (input2 != string.Empty)  // much readable and avoids accidental updation of "" to " " which can cause bugs
            {
                Console.WriteLine($"Second Name is {input2}");
            }
            else
            {
                Console.WriteLine($"No input!!");
            }





            // Equals
            string place = "india";
            string compare = "india";
            if (place == compare) // true
            if (place.Equals(compare)) // true
            // then whats the difference
            {
                Console.WriteLine("Same location");
            } else
            {
                Console.WriteLine("different location");
            }

            // lets see the difference

            char[] location = new char[] { 'i', 'n', 'd', 'i', 'a' };
            object newCompare = string.Concat(location);
            // now notice the type of newcompare ,  it is of object 
            // lets compare it with the place string variable using the both Equals and ==

            if(place == newCompare) // false - but why - becoz == checks both the value and datatype reference 
            {
                Console.WriteLine("new compare is same using ==");
            } else
            {
                Console.WriteLine("new compare is different using ==");
            }

            if(place.Equals(newCompare)) // true - only checks the value stored in the refernced memory
            {
                Console.WriteLine("new comapre is same using Equals");
            } else
            {
                Console.WriteLine("new compare is different using Equals");
            }





            // IsNullOrEmpty
            Console.Write("Enter first name: ");
            string fname = Console.ReadLine();
            if (!string.IsNullOrEmpty(fname))
            {
                Console.WriteLine(fname);
            } else
            {
                Console.WriteLine("No input or null");
            }





            // String in Reverse
            string text = "cats are cutie";
            for (int i = text.Length - 1; i >= 0; i--)
            {
                Console.Write(text[i]); // this is just printing in revserse, the text actually doesnot get reversed  
            }
            Console.WriteLine($"\n{text}");  // still cats are cutie
            text.Reverse(); 
            Console.WriteLine(text);  // still not reversed
            // becoz string is immutable and Reverse() method does not change the original string but returns a new reversed string which we are not storing anywhere
            string reversedText = new string(text.Reverse().ToArray());
            Console.WriteLine(reversedText);

            





        }
    }
}
