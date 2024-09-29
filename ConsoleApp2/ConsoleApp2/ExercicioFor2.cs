using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class ExercicioFor2
    {
        static void Main(string[] args)
        {
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.Write("Entre com as medidas do triângulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Entre com as medidas do triângulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            

            double areaX = x.Area();

           

            double areaY = y.Area();

            Console.WriteLine($"Área de x = {areaX.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Área de y = {areaY.ToString("F4", CultureInfo.InvariantCulture)}");

            if (areaX > areaY) Console.WriteLine("Maior área: X"); else Console.WriteLine("Maior área: Y");
        }
    }
}
