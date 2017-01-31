using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brownbag
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter name: ");
            var input = Console.In.ReadLine();
            Console.WriteLine($"Hello, {input}!");
            Console.ReadKey();
        }
    }
}
