using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LearnCS07_stringIteration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "C# is amazing and cool";

            Console.WriteLine(message[0]);
            Console.WriteLine(message[1]);
            // Console.WriteLine(message[14]);  // out of bounds exceptaion

            for(int i=0;i <message.Length; i++)
            {
                Console.Write(message[i]);
                Thread.Sleep(450);
            }

            Console.WriteLine();
            Console.WriteLine(message.Contains("C"));
        }
    }
}
