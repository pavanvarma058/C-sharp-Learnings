using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _11_Formatting_And_ParseFunc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Numberic formatting
            /*
            double value = 1000D / 12.34D;

            Console.WriteLine(value);
            Console.WriteLine(String.Format("{0:0}", value));
            Console.WriteLine(String.Format("{0:0.0}", value));
            Console.WriteLine(String.Format("{0:0.#}", value));
            Console.WriteLine(String.Format("{0:0.00}", value));

            double money = -10D / 3D;

            Console.WriteLine(money);
            Console.WriteLine(String.Format("-$10 / $3 = ${0:0.00}", value));
            Console.WriteLine(money.ToString("C"));
            Console.WriteLine(money.ToString("C0"));
            Console.WriteLine(money.ToString("C1"));
            Console.WriteLine(money.ToString("C2"));

            Console.WriteLine(money.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-GB")));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-IN")));

            */

            // TryParse function
            Console.Write("Enter a number: ");
            string numIn = Console.ReadLine();

            if (int.TryParse(numIn, out int num)) {
                Console.WriteLine(num);
            }else
            {
                Console.WriteLine("Failed to convert!!");
            }

                Console.ReadLine();
        }
    }
}
