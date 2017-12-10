using System;

namespace Sample.System.Useful
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello System.Useful!");

            Console.WriteLine('a'.GetNumber()); //1
            Console.WriteLine('a'.GetNumberOffset()); //10

            Console.WriteLine('a'.GetNumber(9)); //10
            Console.WriteLine('a'.GetNumberOffset()); //10

            Console.WriteLine('A'.GetNumber()); //1
            Console.WriteLine('A'.GetNumberOffset()); //10

            Console.WriteLine('A'.GetNumber(1)); //2
            Console.WriteLine('B'.GetNumber()); //2
        }
    }
}
