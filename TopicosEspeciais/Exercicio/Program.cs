using System;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);

            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfYear);
            Console.WriteLine("3) DayOfWeek: " + d.Hour);
            Console.WriteLine("3) DayOfWeek: " + d.Kind);
            Console.WriteLine("3) DayOfWeek: " + d.Millisecond);
            Console.WriteLine("3) DayOfWeek: " + d.Minute);
            Console.WriteLine("3) DayOfWeek: " + d.Month);
            Console.WriteLine("3) DayOfWeek: " + d.Second);
            Console.WriteLine("3) DayOfWeek: " + d.Ticks);
            Console.WriteLine("3) DayOfWeek: " + d.TimeOfDay);
            Console.WriteLine("3) DayOfWeek: " + d.Year);

            Console.WriteLine("------------------------------");

            DateTime e = new DateTime(2001, 8, 15, 13, 45, 58);

            string s1 = e.ToLongDateString();
            string s2 = e.ToLongTimeString();
            string s3 = e.ToShortDateString();
            string s4 = e.ToShortTimeString();

            string s5 = e.ToString();

            string s6 = e.ToString("yyyy-MM-dd HH:MM:ss");
            string s7 = e.ToString("yyyy-MM-dd HH:mm:ss.fff");

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);

            Console.WriteLine("------------------------------");

            DateTime f = new DateTime(2001, 8, 15, 13, 45, 58);

            DateTime f2 = f.AddHours(2);
            DateTime f3 = f.AddMinutes(3);

            Console.WriteLine(f2);
            Console.WriteLine(f3);

            Console.WriteLine("------------------------------");

            DateTime g = DateTime.Now;
            DateTime g2 = g.AddDays(7);
            Console.WriteLine(g2);
        }
    }
}
