using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte a, b, c;

            a = 5;
            b = 127;
            c = (sbyte)(a + b);

            Console.WriteLine(c);
            a = 2;
            b = 3;
            c = (sbyte)(a - b);
            Console.WriteLine(c);

            a = -120;
            b = 34;
            c = (sbyte)(a - b);
            Console.WriteLine(c);

            a = -5;
            Console.WriteLine((byte)a);
            a = 56;
            b = 38;
            Console.WriteLine(a & b);

            a = 56;
            b = 38;
            Console.WriteLine(a | b);
            Console.ReadKey();
        }
    }
}
