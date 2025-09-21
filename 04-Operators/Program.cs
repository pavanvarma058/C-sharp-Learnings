using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // +, -, *, /, %
            int age = 23;

            age += 5;
            Console.WriteLine(age);
            age -= 5;
            Console.WriteLine(age);
            age *= 2;
            Console.WriteLine(age);

            double halfage = 23;
            halfage /= 10;
            Console.WriteLine(halfage);

            Console.WriteLine(23 % 10);

            int i = 0;
            Console.WriteLine(++i);
            Console.WriteLine(i++);
            Console.WriteLine(i);
            Console.WriteLine(--i);
            Console.WriteLine(i--);
            Console.WriteLine(i);
            Console.ReadLine();
        }
    }
}
