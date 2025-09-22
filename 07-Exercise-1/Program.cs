using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            -> Define a variable to hold your name
            -> Define a variable to hold your phone number
            -> Define a variable to hold your age
            -> Print variable line by line to screen
            -> Extra: define variables using var keyword
            */

            var name = "Pavan Varma";
            var phoneNum = 1234567890;
            var age = 24;
            Console.WriteLine(name);
            Console.WriteLine(phoneNum);
            Console.WriteLine(age);



            /*
            -> create & initialise two ints
            -> Make a varibale to work out the remainder
            -> Output remainder to screen
            -> Change the first int variable to another number
                 -> and re-calculate the remainder
                 -> output new remainder to screen
            */

            int num1 = 100;
            int num2 = 5;
            Console.WriteLine(num1 % num2);

            num1 = 101;
            Console.WriteLine(num1 % num2);

            Console.ReadLine();
        }
 
    }
}
