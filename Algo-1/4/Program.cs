using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace _4
{
    public class mydecimal
    {
        public static void Znak(int value)
        {
            StringBuilder builder = new StringBuilder(sizeof(byte)*8);
            BitArray[] bitArrays = BitConverter.GetBytes(value).Reverse().Select(b => new BitArray(new[] { b })).ToArray();
            foreach (bool bit in bitArrays.SelectMany(bitArray => bitArray.Cast<bool>().Reverse()))
            {
                builder.Append(bit ? '1' : '0');
            }
            Console.WriteLine(builder[0].ToString());
        }
        public static void Poryadok(int value)
        {
            StringBuilder builder = new StringBuilder(sizeof(byte) * 8);
            BitArray[] bitArrays = BitConverter.GetBytes(value).Reverse().Select(b => new BitArray(new[] { b })).ToArray();
            foreach (bool bit in bitArrays.SelectMany(bitArray => bitArray.Cast<bool>().Reverse()))
            {
                builder.Append(bit ? '1' : '0');
            }
            Console.Write(builder[1].ToString());
            Console.Write(builder[2].ToString());
            Console.Write(builder[3].ToString());
            Console.Write(builder[4].ToString());
            Console.Write(builder[5].ToString());
            Console.WriteLine();
        }
        public static void Mantisa(int value)
        {
            StringBuilder builder = new StringBuilder(sizeof(byte) * 8);
            BitArray[] bitArrays = BitConverter.GetBytes(value).Reverse().Select(b => new BitArray(new[] { b })).ToArray();
            foreach (bool bit in bitArrays.SelectMany(bitArray => bitArray.Cast<bool>().Reverse()))
            {
                builder.Append(bit ? '1' : '0');
            }
            Console.Write(builder[6].ToString());
            Console.Write(builder[7].ToString());
            Console.Write(builder[8].ToString());
            Console.Write(builder[9].ToString());
            Console.Write(builder[10].ToString());
            Console.Write(builder[11].ToString());
            Console.Write(builder[12].ToString());
            Console.Write(builder[13].ToString());
            Console.Write(builder[14].ToString());
            Console.Write(builder[15].ToString());
            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            float aa = float.Parse(Console.ReadLine());
            decimal a = (decimal)aa;
            int[] bits = decimal.GetBits(a);
            Console.WriteLine("{0,0}  {1,10:X8}{2,10:X8}{3,10:X8}{4,10:X8}",
                          a, bits[3], bits[2], bits[1], bits[0]);
            Znak(bits[3]);
            Poryadok(bits[3]);
            Mantisa(bits[3]);
            Console.ReadKey();

            
                        


        }
    }
}
