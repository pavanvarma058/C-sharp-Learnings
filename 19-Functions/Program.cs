using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            helloMessage("Yeswanth");
            helloMessage("Zoro");
            Console.WriteLine();
            int result = add();
            Console.WriteLine(result);
            Console.ReadLine();
        }

        // Functions
        static void helloMessage(string name)
        {
            Console.WriteLine($"Hello {name}");
        }

        // Return type functions
        static int add()
        {
            return 5 + 5;
        }
    }
}
