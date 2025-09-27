using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Exercise_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                -> Create two lists with integer data type, one for even numbers and one for odd 
                     numbers.
                -> Loop from 0-20
                     -> if number is even, add to even list
                     -> if number is odd, add to odd list
                -> Print even list
                -> Print odd list
            */
            /*
            List<int> even = new List<int>();
            List<int> odd = new List<int>();

            for (int i = 0; i <= 20; i++) { 
                if(i % 2 == 0)
                {
                    even.Add(i);
                }
                else
                {
                    odd.Add(i);
                }
            }

            Console.WriteLine("Even Numbers:");
            foreach(int n in even)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();

            Console.WriteLine();

            Console.WriteLine("Odd Numbers:");
            foreach (int n in odd)
            {
                Console.Write(n + " ");
            }   
            Console.WriteLine();
            */

            /*
                -> Define and initialize two integers (num, length)
                -> (7, 5) -> [7, 14, 21, 28, 35]
                -> Create int array with size length
                -> loop through and insert the (loop counter x num) into the array
                -> print the final array
            */

            int num = 7, length = 5;

            int[] arr = new int[length];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = num * (i + 1);
            }

            foreach(int n in arr)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
