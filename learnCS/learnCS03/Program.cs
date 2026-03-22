using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnCS03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double value = 1000D / 12.34;

            Console.WriteLine("{0}", value);
            Console.WriteLine("{0} {1}", value, 1000);

            Console.WriteLine("{0:0.0}", value);
            Console.WriteLine("{0:0.00}", value);
            Console.WriteLine("{0:0.000}", value);

            Console.WriteLine("{0:0.#}", value);

            Console.WriteLine(string.Format("{0:0.#00}", value)); // 0.0# means that if the second decimal place is zero, it will not be displayed.   

            double money = 10D / 3D;
            Console.WriteLine(money);

            Console.WriteLine("{0:0.00}", money);

            Console.WriteLine("The value of $10 / $3 = ${0:0.00}", money); // this is correct
            //but what if we use negative value?
            money = -10D / 3D;
            Console.WriteLine("The value of -$10 / $3 = ${0:0.00}", money);
            // We get format error => $-3.33 , which is not correct.
            //lets see better ways

            Console.WriteLine(money.ToString());  // -3.33333333  not useful, no sign of currency
            Console.WriteLine(money.ToString("0.00"));  // -3.33  better but still no sign of currency

            Console.WriteLine(money.ToString("C")); // -$3.33  this is correct, C means currency, it will automatically add the currency symbol and format the number accordingly.
            Console.WriteLine(money.ToString("C0")); // -$3  this is correct, C0 means currency with no decimal places, it will round the number to the nearest whole number and add the currency symbol.
            Console.WriteLine(money.ToString("C1")); // -$3.3  this is correct, C1 means currency with one decimal place, it will round the number to the nearest tenth and add the currency symbol.
            Console.WriteLine(money.ToString("C2")); // -$3.33  this is correct, C2 means currency with two decimal places, it will round the number to the nearest hundredth and add the currency symbol.
            // it goes to local machine and based on your current data, time, location it figures out the currency symbol and format accordingly


            //if you want to use different currencies 
            Console.WriteLine(money.ToString("C", CultureInfo.CurrentCulture)); //currentCluture decides based on the machine it is running

            // So if this program is ruuning on a cloud computer then it will displayed the information based on where the coud is stored
            //therefore to avoid using currentCluture if we are going to scale worldwide
            // For this we can create specific culture -> focus on negative sign
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-GB")));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))); //brackets in place of negative sign
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-AU")));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture(""))); // no negative sign,  The invariant culture is culture-insensitive; it is associated with the English language but not with any country/region. The invariant culture is used in formatting operations that require culture-independent results. It is also used in string comparisons that require culture-independent results.




        }
    }
}
