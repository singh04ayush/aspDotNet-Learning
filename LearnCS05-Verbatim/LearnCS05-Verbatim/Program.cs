using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LearnCS05_Verbatim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Escape Characters is done by starting with a blackslash

            // \n    \t    \"   \'   \r   \\

            string speech = "he said that \"He is right\"";
            Console.WriteLine(speech);
            string path = "c:\\users\\desktop\\bin";
            Console.WriteLine(path);

            // but using escape characters is pain in the ass but they are still essentials and important
            // till now we have seen the use of $ and + in string
            // $"your name is {name}"
            // "your name is " + name

            // much better way is to use verbatim identifier string by using @ before the string
            path = @"c:\user\ondrive\desktop\bin"; // you dont have to worry about escape char
            Console.WriteLine(path);

            //lets do a next line test
            path = "c:\\user\\onedrive\\desktop\\bin \nnew line test";
            Console.WriteLine(path);
            path = @"c:\user\onedrive\desktop\bin \nnew line test";
            Console.WriteLine(path);

            // if we want new line
            path = @"c:\user\onedrive\desktop\bin" + "\nnew line test";
            Console.WriteLine(path);

            //what about strings
            // if the symbols are different then no issue
            speech = "he said 'animal'";
            Console.WriteLine(speech);

            // but for same have to use 2 times
            speech = @"he said ""animal""";
            Console.WriteLine(speech); // he said "animal"

        }
    }
}
