using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _14_Exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                -> Ask user to input message
                -> Print in order
                -> Print in reverse
            */
            /*
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            for(int i=0; i<name.Length; i++)
            {
                Console.Write(name[i]);
                Thread.Sleep(100);
            }

            Console.WriteLine();
            
            for(int j=name.Length-1; j>=0; j--)
            {
                Console.Write(name[j]);
                Thread.Sleep(100);
            }
            Console.WriteLine();

            */

            // Password checker
            /*
                -> Ask user to enter password, and store
                -> Ask user to enter password again, and store
                -> check if they are both contain something
                    ->If so check they are the same
                        -> If they are, print "passwords match"
                        -> If they are not, print "passwords do not match"
                -> If they are empty, print "please enter a password"
            */

            Console.Write("Enter your password: ");
            string p = Console.ReadLine();
            Console.WriteLine();
            if(!p.Equals(string.Empty))
            {
                Console.Write("Again, Enter your password: ");
                string p1 = Console.ReadLine();
                if (!p1.Equals(string.Empty))
                {
                    if (p.Equals(p1))
                    {
                        Console.WriteLine("Passwords match");
                    }
                    else
                    {
                        Console.WriteLine("Passowords do not match");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter you password for confirmation");
                }
            }
            else
            {
                Console.WriteLine("You didn't enter the password");
            }

            Console.ReadLine();
        }
    }
}
