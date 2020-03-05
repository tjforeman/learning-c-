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
            int age = 15;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine(age);
            Console.WriteLine("Hello World");
            Console.WriteLine("Hello Tyler");
            age = 20;
            Console.WriteLine(age);
            Console.Read();
        }
    }
}
