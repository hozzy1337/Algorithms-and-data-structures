using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            short num = Convert.ToInt16(Console.ReadLine());
            if (num > 0) Console.WriteLine("plus"); else Console.WriteLine("minus");
            Console.WriteLine(Math.Abs(num));
            Console.ReadKey();
        }
    }
}
