using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dictionary -> Key-Value Pairs
            /*
            Dictionary<int, string> names = new Dictionary<int, string>();

            names.Add(1, "Yeswanth");
            names.Add(2, "Sai");
            names.Add(3, "Surya");
            names.Add(4, "Pavan");

            for (int i = 0; i < names.Count; i++) {
                KeyValuePair<int, string> pair = names.ElementAt(i);
                Console.WriteLine($"{pair.Key} : {pair.Value}");
            }

            Console.WriteLine();

            foreach (KeyValuePair<int, string> item in names) {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
            */

            Dictionary<string, string> teachers = new Dictionary<string, string> {
                { "Math", "Yeswanth"},
                { "Science", "Varma"}
            };

            teachers["English"] = "Pavan"; // Add or Update
            teachers["Math"] = "Sai"; // Update

            Console.WriteLine(teachers["Math"]);

            if (teachers.TryGetValue("Science", out string teacher)) {
                Console.WriteLine(teacher);
            }else
            {
                Console.WriteLine("Science teacher not found");
            }

            if (teachers.ContainsKey("Science"))
            {
                teachers.Remove("Science");
            }

            foreach(var item in teachers)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }

                Console.ReadLine();
        }
    }
}
