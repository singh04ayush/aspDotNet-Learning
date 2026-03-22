using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace learnCS04_tryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Problem with Convert function

            /*
            int num = Convert.ToInt32(Console.ReadLine()); // what if user inputs other than numerical value -> ex - 34d, snn4bs3
            Console.WriteLine(num); //Unhandled Exception: System.FormatException: Input string was not in a correct format.
            */



            // Therefore better way is to use Tryparse method
            // returns a bool value true if conversion succeeds and stores the result in out and false if it fails
            string input = Console.ReadLine();
            int num = 0;
            int.TryParse(input, out num);
            Console.WriteLine(num);

            // or
            bool success = int.TryParse(input, out num);
            if (success)
            {
                Console.WriteLine(num);
            }
            else
            {
                Console.WriteLine("faild to convert ");
            }

            // much better way
            // declare the variable in the out parameter itself
            string inp2 = Console.ReadLine(); 
            if (int.TryParse(inp2, out int a))
            {
                Console.WriteLine(a);
            } else
            {
                Console.WriteLine("faild to convert input 2 also");
            }


        }
    }
}
