using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Conversions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Conversions
            string text = "-23";
            int num = Convert.ToInt32(text);
            Console.WriteLine(num);

            string textBigNum = "90000000000";
            long bigNum = Convert.ToInt64(textBigNum);
            Console.WriteLine(bigNum);

            string textNegative = "-55.2";
            double negative = Convert.ToDouble(textNegative);
            Console.WriteLine(negative);

            string textFloat = "5.000001";
            float positive = Convert.ToSingle(textFloat);
            Console.WriteLine(positive);

            string textDecimal = "14.99";
            decimal money = Convert.ToDecimal(textDecimal);
            Console.WriteLine(money);

            Console.ReadLine();
        }
    }
}
