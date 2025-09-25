using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for a number for the table
            // Write a for loop to print X times table
            /*
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for(int i=1; i<=10; i++)
            {
                int ans = num * i;
                Console.WriteLine(num + " x " + i + " = " + ans);
            }
            */

            /*
             -> Create a for loop from 1 to X (15)
            -> 3 and 5 = FizzBuzz
            -> 3 = Fizz
            -> 5 = Buzz
            -> else = number
             */
            int x = 15;
            for (int i = 1; i <= x; i++) {
                if (i % 3 == 0 && i % 5 == 0) {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0) {
                    Console.WriteLine("Fizz");
                }
                if (i % 5 == 0) {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }
    }
}
