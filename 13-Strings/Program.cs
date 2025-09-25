using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading; // -> For Thread.Sleep 

namespace _13_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            // \t, \n, \", \\, =, \ -> escape characters
            string speech = "He said \"something\"";
            string path = "C:\\Users\\Admin\\Documents";
            string newLine = "First line\nSecond line";
            Console.WriteLine(speech);
            Console.WriteLine(path);
            Console.WriteLine(newLine);

            // $, + 
            // ${"Your name is {name}"}
            // "Hello " + name
            // @ -> verbatim string literal
            path = @"C:\Users\Admin\Documents";
            Console.WriteLine(path);

            string name = @"Hell ""something""";
            Console.WriteLine(name);

            name = "Hello 'someone'";
            Console.WriteLine(name);
            */

            /*
            // String Formatting
            string person = "Pavan";
            int age = 24;

            Console.WriteLine("Name: " + person);
            Console.WriteLine("Age: " + age);

            Console.WriteLine();

            Console.WriteLine("Name: " + person + "\nAge: " + age);

            Console.WriteLine();

            Console.WriteLine("Your name is " + person + " and your age is " + age);
            
            // Composite formatting
            Console.WriteLine("Your name is {0} and your age is {1}", person, age);
            */

            /*
            // String interpolation
            string name1 = "Yeswanth";
            int age = 24;

            Console.WriteLine($"Your name is {name1} and age is {age}");

            // String concatenation
            Console.WriteLine("Your name is " + name1 + " and age is " + age);
            */

            /*
            // String .Empty
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            if(name != string.Empty)
            {
                Console.WriteLine($"Thank you {name}");
            }
            else {
                Console.WriteLine("The name is empty");
            }
            */

            /*
            // String .Equals
            string compare = "Hello";
            string message = "Hello";

            // if(compare == message) -> Here it only compares the reference of both the strings
            if (compare.Equals(message)) // -> Here it compares the value of both the strings
            {
                Console.WriteLine("Both are equal");
            }
            else
            {
                Console.WriteLine("Both are not equal");
            }
            */

            /*
            // String Iteration
            string text = "C# is a programming language";

            Console.WriteLine(text[0]);
            Console.WriteLine(text[1]);
            Console.WriteLine(text[2]);
            Console.WriteLine(text[3]);

            for (int i = 0; i < text.Length; i++) {
                Console.Write(text[i]);
                Thread.Sleep(100); // -> Sleep for 100 milliseconds
            }
            Console.WriteLine();

            Console.WriteLine(text.Contains("l"));
            */

            // String isNullOrEmpty
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine($"Your name is {name}");

            if(name != "")
            {
                Console.WriteLine("0");
            }
            if (!name.Equals(""))
            {
                Console.WriteLine("1");
            }
            if (!string.IsNullOrEmpty(name)) {
                Console.WriteLine("2");
            }
            Console.ReadLine();
        }
    }
}
