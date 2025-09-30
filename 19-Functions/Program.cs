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
            //helloMessage("Yeswanth");
            //helloMessage("Zoro");
            //Console.WriteLine();
            //int result = add();
            //Console.WriteLine(result);

            /*
            int num = ReadInt("Enter a number: ");
            Console.WriteLine(num);

            int angle = ReadInt("Enter an angle: ");
            Console.WriteLine(angle);

            string name = ReadString("Enter your name: ");
            int age = ReadInt("Enter your age: ");
            string details = UserDetails(name, age);
            Console.WriteLine(details);
            */
            /*
            PrintName();
            PrintName("Yeswanth");
            */
            /*
            List<string> shoppingList = new List<string>(){
                "Milk", "Coffee", "Bread" };

            Console.WriteLine(shoppingList.IndexOf("Bread"));
            Console.WriteLine(FindInList("Bread", shoppingList, out int index));
            Console.WriteLine(index);
            */

            int num = 10;
            string name = "Pavan";
            Assign(ref num, ref name);
            Console.WriteLine(num);
            Console.WriteLine(name);
            Console.ReadLine();
        }

        // Ref parameters
        static void Assign(ref int number, ref string str)
        {
            number = 100;
            str = "Yeswanth";
        }

        // Out parameters
        static bool FindInList(string s, List<string> list, out int index)
        {
            index = -1;

            for(int i=0; i<list.Count; i++)
            {
                if (list[i].ToLower().Equals(s.ToLower()))
                {
                    index = i;
                }
            }
            bool found = index > -1;
            return found;
        }

        // Optional parameters
        static void PrintName(string name = default) {
            Console.WriteLine($"My name is {name}");
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

        // Function parameters

        static string UserDetails(string name, int age)
        {
            return $"Hello my name is {name} and my age is {age}";
        }    

        static string ReadString(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
        static int ReadInt(string message) {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }


    }
}
