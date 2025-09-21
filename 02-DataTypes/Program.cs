using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Data Types

            // Integer - whole numbers
            int age = 23;
            Console.WriteLine(age);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            // Long - whole numbers (bigger range)
            long bigNumber = 90000000000L;
            Console.WriteLine(bigNumber);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);

            // Double - decimal numbers
            double negative = -55.2D;
            Console.WriteLine(negative);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);

            // Float - decimal numbers (less precision)
            float positive = 22.88F;
            Console.WriteLine(positive);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);

            // Decimal - decimal numbers (more precision, money)
            decimal money = 14.99M;
            Console.WriteLine(money);
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);

            // String - text
            string name = "Pavan";
            Console.Write("Your name is ");
            Console.Write(name);
            Console.WriteLine();

            // Char - single character
            char letter = 'A';
            Console.WriteLine(letter);

            // Bool - true or false
            bool isTrue = true;
            bool isMale = true;
            Console.ReadLine();
        }
    }
}
