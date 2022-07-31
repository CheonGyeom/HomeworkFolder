using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int i1 = 3;
            string s1 = "Hi";

            Console.WriteLine("{0} {1}" ,i1,s1);
            Console.WriteLine($"{i1} {s1}");
            Console.WriteLine(i1 + " " + s1);
        }
    }
}