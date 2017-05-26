using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algo_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("\nИнтегралы:\n1). Прямоугольники: {0}", RectangleMet(a, b));
            Console.WriteLine("2). Трапеции: {0}", TrapeziumMet(a, b));
            Console.WriteLine("3). Симпсон: {0}", SimpsonMet(a, b));
            Console.WriteLine("4). Монте-карло: {0}", MonteKarlo(a, b));
            Console.ReadKey();
        }

        static double MonteKarlo(double a, double b)
        {
            double integ = 0;
            double k = b - a;
            double s = 0;
            Random rnd = new Random();
            for (int i = 0; i < 10000; i++)
            {
                double g = rnd.NextDouble();
                double x = a + g * (b - a);
                s += (Math.Pow(x, 2));
            }
            integ = (0.0001) * k * s;
            return integ;
        }

        static double RectangleMet(double a, double b)
        {
            double integral = 0, step = 0.001;
            for (double i = a; i < b; i += step)
            {
                integral += Math.Pow(i,2);
            }
                integral *= step;
                return integral;
            }

        static double TrapeziumMet(double a, double b)
        {
            double integral = 0, step = 0.001f;
            for (double i = a; i < b; i += step)
            {
                integral += 2 * Math.Pow(i, 2);
            }
            integral = (integral + Math.Pow(a, 2) + Math.Pow(b, 2)) * step / 2;
            return integral;
        }

        static double SimpsonMet(double a, double b)
        {
            int n = 1;
            double step = 0.001f, integral = 0, integral1 = 0, integral2 = 0;
            for (double i = a; i < b; i += step)
            {
                if (n % 2 == 0)
                {
                    integral1 += Math.Pow(i, 2);
                }
                else
                {
                    integral2 += Math.Pow(i, 2);
                }
                n++;
            }
            integral = (integral + Math.Pow(a, 2) + Math.Pow(b, 2) + 4 * integral2 + 2 * integral1) * step / 3;
            return integral;
        }
    }
}
