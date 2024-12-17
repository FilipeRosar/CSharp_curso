using System;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2000,12,3,13,5,58, DateTimeKind.Local);
            DateTime d2 = new DateTime(2000,12,3,13,5,58, DateTimeKind.Utc);
            DateTime d3 = new DateTime(2000, 12, 3,13, 5, 58);

            Console.WriteLine($"d1: {d1}");
            Console.WriteLine($"d1 kind: {d1.Kind}");
            Console.WriteLine($"d1 to Local: {d1.ToLocalTime()}");
            Console.WriteLine($"d1 to UTC: {d1.ToUniversalTime()}");

            Console.WriteLine();

            Console.WriteLine($"d2: {d2}");
            Console.WriteLine($"d2 kind: {d2.Kind}");
            Console.WriteLine($"d2 to Local: {d2.ToLocalTime()}");
            Console.WriteLine($"d2 to UTC: {d2.ToUniversalTime()}");

            Console.WriteLine();

            Console.WriteLine($"d3: {d3}");
            Console.WriteLine($"d3 kind: {d3.Kind}");
            Console.WriteLine($"d3 to Local: {d3.ToLocalTime()}");
            Console.WriteLine($"d3 to UTC: {d3.ToUniversalTime()}");

            //TimeSpan t1 = TimeSpan new(1,30,10);
            //TimeSpan t2 = TimeSpan new(0, 10,5);

            //TimeSpan sum = t1.Add(t2);
            //TimeSpan dif = t1.Subtract(t2);
            //TimeSpan mult = t2.Multiply(2.0);
            //TimeSpan div = t2.Divide(2.0);

            //Console.WriteLine(sum);
            //Console.WriteLine(dif);
            //Console.WriteLine(mult);
            //Console.WriteLine(div);


            //DateTime d = new DateTime(2000,12,3, 13,45,48);

            //string s1 = d.ToLongTimeString();
            //string s2 = d.ToLongTimeString();
            //string s3 = d.ToShortDateString();
            //string s4 = d.ToShortTimeString();

            //Console.WriteLine(s1);
            //Console.WriteLine(s2);
            //Console.WriteLine(s3);
            //Console.WriteLine(s4);
        }
    }
}