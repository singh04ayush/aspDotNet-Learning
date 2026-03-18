using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace learnCS01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int age = 10;
            Console.WriteLine(age);

            long b1 = 28376546738232;
            Console.WriteLine("processed as int");
            Console.WriteLine(b1);
            // To process the number as long, we need to add 'L' at the end of the number
            long b2 = 28376546738232L;
            Console.WriteLine("processed as long");
            Console.WriteLine(b2);


            // Int Max and Min values
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            double d1 = 34.5D; // 34.5D
            Console.WriteLine(d1);
            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);


            float f1 = 34.5F;
            Console.WriteLine(f1);
            Console.WriteLine(float.MinValue);
            Console.WriteLine(float.MaxValue);

            decimal price = 34.99M;
            Console.WriteLine(price);
            Console.WriteLine(decimal.MinValue);
            Console.WriteLine(decimal.MaxValue);


            string textnum = "252";
            int num = Convert.ToInt32(textnum);
            Console.WriteLine(num);

            string bignum = "8763456876345";
            long bignum2 = Convert.ToInt64(bignum);
            Console.WriteLine(bignum2);

            string textfloat = "56.44";   // not "56.44F" coz we are mentioning it
            float num2 = Convert.ToSingle(textfloat);
            Console.WriteLine(num2);

            string textdouble = "344.343"; // not "344.343D"
            double num3 = Convert.ToDouble(textdouble);
            Console.WriteLine(num3);

            string textdecimal = "199.99";  // not "199.99M"
            decimal num4 = Convert.ToDecimal(textdecimal);
            Console.WriteLine(num4);


            string checknum = "345h";
            Console.WriteLine(checknum);
            // If we try to convert a string that contains non-numeric characters, it will throw an exception


            bool isOut = false;
            Console.WriteLine(isOut);
            isOut = true;
            Console.WriteLine(isOut);
            //isOut = 0;                 will not work
            //Console.WriteLine(isOut);      


            int height = 53;
            height++;
            height = height + 1;   // these three lines do the exact same thing
            height += 1;
            Console.WriteLine(height);
            height--;
            Console.WriteLine(height);

            height = height / 10;   // give 5 not 5.3 coz type is int
            Console.WriteLine(height);
            double ages = 36;
            ages = ages / 10;
            Console.WriteLine(ages);


            // + operator on string

            string firstName = "Ayush";
            firstName = firstName + " Singh";
            Console.WriteLine(firstName);

            int firstnum = 34;
            int secondnum = 10;
            Console.WriteLine(firstnum % secondnum);  // remainder


            // var keyword
            // automatically detects the type based on the value initailized
            var dis = 546;
            var gender = "Male";
            var bigg = 939393993L;
            var token = 'G';
            Console.WriteLine(dis);
            Console.WriteLine(gender);
            Console.WriteLine(bigg);
            Console.WriteLine(token);


            // const keyword
            const int vat = 20;
            int balance = 1000;
            Console.WriteLine(balance * (vat/100D));
            const double percentvat = vat / 100D;
            Console.WriteLine(balance * percentvat);  //same 200
            // vat = 30;   -> cannot change the value of const variable gives error
            const string Version = "v.1.0";
            Console.WriteLine(Version);

            Console.ReadLine();
        }
    }
}
