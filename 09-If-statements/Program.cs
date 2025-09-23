using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_If_statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // conditional statements
            // if, else if, else
            // > , < , >= , <= , == , != , || , &&
            /*
            Console.Write("Enter your age: ");
            string ageIn = Console.ReadLine();
            int age = Convert.ToInt32(ageIn);

            if (age >= 18 && age <= 25)
            {
                Console.WriteLine("You are between 18 and 25");
            }
            else if (age >= 26) {
                Console.WriteLine("You are 26");
            }
            */
            /*
            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int answer = num1 * num2;

            Console.Write("Can you guess the value of num1 " + "*" + " num2: ");
            int guess = Convert.ToInt32(Console.ReadLine());

            if(answer == guess)
            {
                Console.WriteLine("Well Done :)");
            }else
            {
                Console.WriteLine("Your guess is wrong :(");
            }
            */


            Console.Write("Enter the day of the week: ");
            int day = Convert.ToInt32(Console.ReadLine());

            switch (day) {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid, enter a value between 1 and 7");
                    break;
            }

            Console.ReadLine();
        }
    }
}
