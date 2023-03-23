using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { -5, -8, 0, 1, 3 };
            Array.Sort(array);
            foreach (int elem in array)
            {
                Console.WriteLine($"{elem}");
            }
            Console.WriteLine();
            Array.Reverse(array);
            foreach (int elem in array)
            {
                Console.WriteLine($"{elem}");
            }
            Console.Read();
        }
    }
}
