using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnCS02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "aba";
            Console.Write("My name is: ");
            Console.WriteLine(name);

            char letter = 'j';
            Console.WriteLine(letter);

            // You can have empty string but cannot empty char
            string name2 = "";  //valid -> empty string - > default value of string is null
            string name3 = null; // valid -> null string
            //char lettter2 = '';   ->  invalid
            char defaultChar = '\0';   // deafult value of char is '\0' which is null character

            Console.WriteLine(name2);
            Console.WriteLine(name3);
            
            Console.WriteLine(defaultChar);


            Console.Write("Enter the number A: ");
            int numa = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the number B: ");
            int numb = Convert.ToInt32(Console.ReadLine());

            Console.Write("Guess the Multiplaction of these two numbers: ");
            int guess = Convert.ToInt32(Console.ReadLine());

            int answer = numa * numb;

            if (answer == guess)
            {
                Console.WriteLine("Well Done!");
            }else
            {
                Console.WriteLine("close but incorrect!");
            }



            Console.ReadLine();
        }
    }
}
