using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("Enter your name");
            string input = Console.ReadLine();
            Console.WriteLine("Hello" + input);
            Console.ReadKey();
        }
    }
}
