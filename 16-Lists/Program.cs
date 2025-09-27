using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // lists -> dynamic arrays
            List<int> numbers = new List<int>();

            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

            // some methods in lists
            numbers.Remove(3); // remove by value

            numbers.RemoveAt(0); // remove by index

            foreach(int n in numbers)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();

            Console.WriteLine(numbers.Contains(5));

            Console.ReadLine();
        }
    }
}
