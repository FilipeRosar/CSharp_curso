// See https://aka.ms/new-console-template for more information
using ExercicioPOO01;
using System;
using System.Globalization;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo objeto = new();
            Console.WriteLine("Entre com a largura e altura do retângulo: ");

            objeto.Largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            objeto.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            
            Console.WriteLine($"AREA = {objeto.Area().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"PERIMETRO = {objeto.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"DIAGONAL = {objeto.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");


        }
    }
}
