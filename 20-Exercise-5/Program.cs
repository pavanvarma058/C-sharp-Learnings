using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Exercise_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                -> Ask user for width and height, and store them
                -> Create function to calculate area
                -> Function should calculate the area using: (width * height) / 2
                -> Call in main and print out the area of the triangle
            */
            /*
            Console.Write("Enter width: ");
            int width = int.Parse(Console.ReadLine());

            Console.Write("Enter height: ");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int area = CalculateArea(width, height);
            Console.WriteLine($"Area of triangle is {area}");
            */

            /*
                -> Create and initialise int array of numbers
                -> Create function SumOfNumbers with int return type
                -> int array parameter
                -> function should return total of numbers
                -> Call in main and output the total
                -> Extra:
                    -> return -1 if array is empty
                    -> check return in main and output message
                    -> do we need to return -1, how else can we make this?
            */
            int[] arr = new int[] { 1, 2, 5, 8, 44, 45, 78, 99, 88, 77, 25};
            int total = SumOfNumbers(arr);
            if(total > -1)
            {
                Console.WriteLine($"The Sum of array numbers is: {total}");
            }
            else
            {
                Console.WriteLine("It's an empty array");
            }


                Console.ReadLine();
        }

        static int SumOfNumbers(int[] arr)
        {
            int add = 0;
            if(arr.Length == 0)
            {
                return -1;
            }
            for(int i=0; i<arr.Length; i++)
            {
                add += arr[i];
            }
            return add;
        }

        static int CalculateArea(int width, int height)
        {
            return (width * height) / 2;
        }
    }
}
