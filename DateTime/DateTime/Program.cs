using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime d1 = DateTime.ParseExact("2000-12-03", "yyyy-MM-dd",CultureInfo.InvariantCulture);
            DateTime d2 = DateTime.ParseExact("03/12/2000 13:06:15", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);


            Console.WriteLine(d1);
            Console.WriteLine(d2);

            //DateTime d1 = DateTime.Parse("2000-12-03");
            //DateTime d2 = DateTime.Parse("2000-12-02 09:05:57");
            //DateTime d3 = DateTime.Parse("15/08/2000");

            //Console.WriteLine(d1);
            //Console.WriteLine(d2);
            //Console.WriteLine(d3);

            //DateTime d1 = new DateTime(2024, 11, 25);
            //DateTime d2 = new DateTime(2024, 11, 12,20,42,12);
            //DateTime d3 = new DateTime(2024, 11, 12, 20, 42, 12,500);

            //DateTime d4 = DateTime.Now;
            //DateTime d5 = DateTime.Today;
            //DateTime d6 = DateTime.UtcNow;

            //Console.WriteLine(d1);
            //Console.WriteLine(d2);
            //Console.WriteLine(d3);
            //Console.WriteLine(d4);
            //Console.WriteLine(d5);
            //Console.WriteLine(d6);
        }
    }
}