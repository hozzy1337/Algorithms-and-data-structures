using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //@Section variables
            //------------------------------------------------------
            Int64 m = 2147483647;
            int c = 1103;
            Int64 a = 11003515245;
            decimal sum=0;
            decimal dcp = 0;
            double[] rand = new double[5001];
            double[] d = new double[5001];
            rand[0] = 150;
            double[] mass = new double[301];
            double[] chast = new double[301];
            //@Section arrays
            //------------------------------------------------------
            for (int i = 0; i <300 ; i++)
            {
                mass[i] = i;
            }

            for (int i = 0; i <= 4999; i++) {
                rand[i + 1] = (rand[i] * a + c) % m;
                d[i] = ((rand[i + 1]) / (m-1)) * 300;
                sum += (decimal)d[i];
                Console.WriteLine(d[i]);
            }

            for (int i = 0; i < 4999; i++)
            {
                for (int j = 0; j < 300; j++)
                {
                    if ((int)d[i] == mass[j]) chast[j]++;
                }
            }

            //@Section math
            //------------------------------------------------------
            for (int i = 0; i < 300; i++)
            {
                Console.WriteLine("Частота для числа {0} = {1}",i,chast[i]/5000);
            }
            double chastota = 1 / Math.Log(m);
                
            for (int i = 0; i <= 4999; i++)
			{
                dcp += (decimal)Math.Pow(((float)d[i] - (float)sum)*chastota,2); 
			}
    
            Console.WriteLine("Дисперсiя {0}", dcp);
            Console.WriteLine("Середньоквадратичне {0}", Math.Sqrt((double)dcp));
            Console.WriteLine("Сподiвання {0}", sum / 5000);
            Console.ReadKey();

        }
    }
}
