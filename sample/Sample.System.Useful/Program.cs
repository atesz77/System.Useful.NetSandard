using System;
using System.Collections.Generic;

namespace Sample.System.Useful
{
    enum TestEnum {
        Test1,
        Test2,
        Test3,
    }

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

            3.Times(() => {
                Console.WriteLine("asd");
            });

            3.Times((i) => {
                Console.WriteLine($"asd {i}");
            });

            List<int> asdList = new List<int> {1, 2, 3, 4, 5};
            PyList<int> pylist = asdList;

            Console.WriteLine(pylist[1]);
            Console.WriteLine(pylist["-1"].Join(", "));
            Console.WriteLine(pylist["1:3"].Join(", "));
            Console.WriteLine(pylist["0::2"].Join(", "));
            Console.WriteLine(pylist["::-1"].Join(", "));

            TestEnum t = TestEnum.Test3;

            Console.WriteLine(t);
            Console.WriteLine((int)t);

            var te = "Test2".ToEnum<TestEnum>();
            Console.WriteLine(te);
            Console.WriteLine((int)te);
        }
    }
}
