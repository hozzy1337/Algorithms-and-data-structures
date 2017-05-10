using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{

    class Program
    {

        public struct myDateTime
        {
            public static DateTime moment = DateTime.Now;

            public int year;

            public int month;

            public int day;

            public int hour;

            public int minute;

            public int second;

            public int millisecond;

            public myDateTime(DateTime moment)
            {
            year = moment.Year;

            month = moment.Month;

            day = moment.Day;

            hour = moment.Hour;

            minute = moment.Minute;

            second = moment.Second;

            millisecond = moment.Millisecond;
            }
        }


        static void Main(string[] args)
        {
            DateTime moment = DateTime.Now;
            myDateTime date = new myDateTime(moment);
            Console.WriteLine("{0}.{1}.{2} {3}:{4}:{5}:{6}", date.day, date.month, date.year, date.hour, date.minute, date.second, date.millisecond);
            Console.ReadKey();
        }
    }
}
