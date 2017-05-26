using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Algo_5
{
    class Program
    {


        static double SummaNegative(double[] arr)
        {
            double summa = 0;
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] < 0)
                    summa += arr[i];
            return summa;
        }
        static double[] GenerateArray(int size,
            int minValue, int maxValue, int precision)
        {
            double[] arr = new double[size];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
                arr[i] = Math.Round(rnd.NextDouble() * (maxValue - minValue) +
                    minValue, precision);
            return arr;
        }
        static void WriteArray(double[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine("arr[{0}] == {1}", i, arr[i]);
        }
        static void BubbleSort(double[] arr)
        {
            int i;
            double tmp;
            bool flag;
            do
            {
                flag = false;
                for (i = 0; i < arr.Length - 1; i++)
                    if (arr[i] > arr[i + 1])
                    {
                        tmp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = tmp;
                        flag = true;
                    }
            } while (flag);
        }

        public static void ShakerShaker(double[] arr)
        {
            double b = 0;
            int left = 0;
            int right = arr.Length - 1;
            while (left < right)
            {
                for (int i = left; i < right; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        b = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = b;
                        b = i;
                    }
                }
                right = (int)b;
                if (left >= right) break;
                for (int i = right; i > left; i--)
                {
                    if (arr[i - 1] > arr[i])
                    {
                        b = arr[i];
                        arr[i] = arr[i - 1];
                        arr[i - 1] = b;
                        b = i;
                    }
                }
                left = (int)b;
            }
        }

        public static void SelectionSort(double[] arr)
        {
            double temp;
            int min;
            int length = arr.Length;

            for (int i = 0; i < length - 1; i++)
            {
                min = i;

                for (int j = i + 1; j < length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }

                if (min != i)
                {
                    temp = arr[i];
                    arr[i] = arr[min];
                    arr[min] = temp;
                }
            }
        }

        public static void InsertionSort(double[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                double cur = array[i];
                int j = i;
                while (j > 0 && cur < array[j - 1])
                {
                    array[j] = array[j - 1];
                    j--;
                }
                array[j] = cur;
            }
        }

        public static void shellSort(double[] arr)
        {
            int j;
            int step = arr.Length / 2;
            while (step > 0)
            {
                for (int i = 0; i < (arr.Length - step); i++)
                {
                    j = i;
                    while ((j >= 0) && (arr[j] > arr[j + step]))
                    {
                        double tmp = arr[j];
                        arr[j] = arr[j + step];
                        arr[j + step] = tmp;
                        j -= step;
                    }
                }
                step = step / 2;
            }
        }

        static void Main(string[] args)
        {
            int count, min, max, prec;
            Stopwatch watch = new Stopwatch();
            Console.Write("Count = ");
            count = int.Parse(Console.ReadLine());
            Console.Write("MinValue = ");
            min = int.Parse(Console.ReadLine());
            Console.Write("MaxValue = ");
            max = int.Parse(Console.ReadLine());
            Console.Write("Precision = ");
            prec = int.Parse(Console.ReadLine());
            double[] arr, arrayForSorting;
            arr = GenerateArray(count, min, max, prec);
            /*Console.WriteLine("Array:");
            WriteArray(arr);
            Console.WriteLine("Sorted Array:");*/

            arrayForSorting = (double[])arr.Clone();
            watch.Start();
            BubbleSort(arrayForSorting);
            watch.Stop();
            Console.WriteLine("Bubble Sorting Time: {0}", watch.Elapsed);
            watch.Reset();

            arrayForSorting = (double[])arr.Clone();
            watch.Start();
            ShakerShaker(arrayForSorting);
            watch.Stop();
            Console.WriteLine("Shaker sort time: {0}", watch.Elapsed);
            watch.Reset();

            arrayForSorting = (double[])arr.Clone();
            watch.Start();
            SelectionSort(arrayForSorting);
            watch.Stop();
            Console.WriteLine("Selection sort time: {0}", watch.Elapsed);
            watch.Reset();

            arrayForSorting = (double[])arr.Clone();
            watch.Start();
            InsertionSort(arrayForSorting);
            watch.Stop();
            Console.WriteLine("Insertion sort time: {0}", watch.Elapsed);
            watch.Reset();

            arrayForSorting = (double[])arr.Clone();
            watch.Start();
            shellSort(arrayForSorting);
            watch.Stop();
            Console.WriteLine("Shell sort time: {0}", watch.Elapsed);
            watch.Reset();

            arrayForSorting = (double[])arr.Clone();
            watch.Start();
            Array.Sort(arrayForSorting);
            watch.Stop();
            Console.WriteLine(".NET Sorting Time: {0}", watch.Elapsed);
            watch.Reset();

            Console.ReadKey();
        }
    }
}
