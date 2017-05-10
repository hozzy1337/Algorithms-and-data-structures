using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            short num = Convert.ToInt16(Console.ReadLine());
            int res = num & Math.Abs(num);
            if (res != num) Console.WriteLine("minus"); else Console.WriteLine("plus");
            Console.WriteLine(Math.Abs(num));
            Console.ReadKey();
        }
    }
}
