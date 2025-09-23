using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Loops

            // for loop
            for (int i = 1; i <= 10; i++) {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            // while loop
            int j = 1;

            while(j <= 10)
            {
                Console.WriteLine(j);
                j++;
            }
            Console.WriteLine();
            
            // do while loop
            int k = 1;

            do
            {
                Console.WriteLine(k);
            }while(k != 1);


            // Condition ? True : False;
            int age = 18;
            Console.WriteLine(age >= 18 ? "Valid" : "Invalid");

            Console.ReadLine();
        }
    }
}
