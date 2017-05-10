using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2._1
{
    class Program
    {
        public struct mySignedShort
        {

            public bool sign;// 1 mean +, 0 mean -
            public short value;

            public mySignedShort(short num)
            {
                if (num < 0) sign = false; else sign = true;
                value = Math.Abs(num);
            }
        }

        static void Main(string[] args)
        {
            short num = Convert.ToInt16(Console.ReadLine());
            mySignedShort number = new mySignedShort(num);
            Console.WriteLine();
            if (number.sign == false) Console.WriteLine("minus"); else Console.WriteLine("plus");
            Console.WriteLine(number.value);
            Console.ReadKey();
        }
    }
}
