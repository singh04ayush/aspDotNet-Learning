using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercise - 01
            // Print table of the number given by user 
            Console.Write("Enter the value: ");
            string input = Console.ReadLine();
            if(int.TryParse(input, out int num))
            {
                for(int i=1;i <=10; i++)
                {
                    Console.WriteLine("{0} X {1} = {2}", num, i, num * i);
                }
            } else
            {
                Console.WriteLine("Invalid Input!");
            }


            // Exercise - 02
            // Fizz Buzz Problem
            for (int i=1; i<=15; i++)
            {
                bool isDivByThree = i % 3 == 0;
                bool isDivByFive = i % 5 == 0;

                if (isDivByThree && isDivByFive) Console.WriteLine("FizzBuzz");
                else if (isDivByThree) Console.WriteLine("Fizz");
                else if (isDivByFive) Console.WriteLine("Buzz");
                else Console.WriteLine(i);
            }


            // Exercise - 03
            // passowrd checker
            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            Console.Write("Enter password again: ");
            string confirmPassword= Console.ReadLine();

            if( !string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(confirmPassword))
            {
                if(password.Equals(confirmPassword))
                {
                    Console.WriteLine("password matched and saved");
                } else
                {
                    Console.WriteLine("Password do not matches");
                }
            } else
            {
                Console.WriteLine("Invalid Input!!");
            }

        }
    }
}
