using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _05_Var_keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // var keyword
            var age = 23;
            Console.WriteLine(age);

            var bigNum = 90000000000L;
            Console.WriteLine(bigNum);

            var negative = -55.2D;
            Console.WriteLine(negative);

            var precision = 5.000001F;
            Console.WriteLine(precision);

            var money = 14.99M;
            Console.WriteLine(money); 

            var name = "Pavan";
            Console.WriteLine(name);

            var letter = 'A';
            Console.WriteLine(letter);

            Console.ReadLine();
        }
    }
}
