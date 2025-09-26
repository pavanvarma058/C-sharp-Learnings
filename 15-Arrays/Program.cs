using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Arrays
            /*
            int[] numbers = new int[3];

            // Input
            for (int i = 0; i < numbers.Length; i++) {
                Console.Write("Enter a number: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Output
            for (int i = 0; i < numbers.Length; i++) {
                Console.Write($"{numbers[i]} ");
            }

            Console.WriteLine();

            // for Each
            foreach (int n in numbers) {
                Console.Write($"{n} ");
            }
            */

            /*
            // Angles of a triangle
            int angleCount = 3;
            int[] angles = new int[angleCount];

            for(int i=0; i<angles.Length; i++)
            {
                Console.Write($"Enter angle {i + 1}: ");
                angles[i] = Convert.ToInt32(Console.ReadLine());
            }

            int sum = 0;
            foreach(int n in angles)
            {
                sum += n;
            }

            Console.WriteLine(sum == 180 ? "Valid" : "Invalid");
            */

            // Array Sorting
            int[] arr = new int[]{
                5, 3, 8, 2, 1, 0, 4, 7, 9, 6 };

            Array.Sort(arr);

            foreach (int n in arr) {
                Console.Write(n + " ");
            }
            Console.WriteLine();

            // Array Reversing
            int[] arr1 = new int[]{
                1, 2, 3, 4, 5};

            Array.Reverse(arr1);

            foreach (int n in arr1) {
                Console.Write(n + " ");
            }
            Console.WriteLine();

            // Array Clear
            int[] arr2 = new int[]{
                1, 2, 3, 4, 5};

            Array.Clear(arr2, 0, arr2.Length);

            foreach (int n in arr2) {
                Console.Write(n + " ");
            }
            Console.WriteLine();

            Console.ReadLine();

        }
    }
}
