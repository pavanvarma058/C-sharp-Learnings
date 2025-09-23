using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_ConsoleIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hi my name is Pavan!");

            Console.Write("What is your name: ");
            string name = Console.ReadLine();
            //Console.WriteLine(name);

            Console.Write("Enter your age: ");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);
            //Console.WriteLine(age);

            Console.WriteLine();

            Console.WriteLine("Your name is " + name + " and your age is " + age);

            Console.ReadLine();
        }
    }
}
