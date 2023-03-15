﻿using DateTime = System.DateTime;

namespace DateAndTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var now = DateTime.Now;

            Console.WriteLine(now.DayOfWeek.ToString());
            Console.WriteLine($@"{now.Day:00}/{now:MMMM}/{now.Year:0000}");
            Console.WriteLine($@"{now.Hour:00}:{now.Minute:00}:{now.Second:00}");

            Console.WriteLine(now.Date);
            Console.WriteLine(now.TimeOfDay);
            Console.WriteLine(now.ToString());
            string date = now.ToString("yyyy-MM-dd");
            Console.WriteLine(date);
            string time = now.ToString("HH:mm:ss");
            Console.WriteLine(time);

            Console.ReadKey();



        }
    }
}