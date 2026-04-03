using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03
{
    internal static class Helper
    {
        public static void PrintList<T>(string listName, List<T> items)
        {
            Console.WriteLine($"{listName} : [{string.Join(", ", items)}]");

        }

        public static void PrintHashSet<T>(string setName, HashSet<T> items)
        {
            Console.WriteLine($"{setName} : [{string.Join(", ", items)}]");

        }
    }
}
