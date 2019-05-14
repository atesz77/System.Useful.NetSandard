using System;
using System.Collections.Generic;

namespace Sample.System.Useful
{
    enum TestEnum {
        Test1,
        Test2,
        Test3,
    }

    class Medve
    {
        public int Asd { get; set; }
        public string Qwe { get; set; }  
        public Cica P { get; set; }  
        public bool Wert { get; set; } 
    }

    class Cica 
    {
        public int Jkl { get; set; }
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

            List<Medve> testList = new List<Medve>{
                new Medve { Asd = 10, Qwe = "Cica", Wert = true, P = new Cica { Jkl = 55 }},
                new Medve { Asd = 20, Qwe = "Veréb", Wert = true, P = new Cica { Jkl = 66 }},
                new Medve { Asd = 30, Qwe = "Kutya", Wert = false, P = new Cica { Jkl = 77 }},
                new Medve { Asd = 40, Qwe = "Medve", Wert = true, P = new Cica { Jkl = 88 }},
            };

            var testSelect = testList.SelectDebugProps("Asd", "Qwe", "P.Jkl");

            foreach (dynamic item in testSelect)
            {
                Console.WriteLine(item.Asd);
                Console.WriteLine(item.Qwe);
                Console.WriteLine(item.P_Jkl);
                Console.WriteLine();
            }

        }
    }
}
