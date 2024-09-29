﻿// See https://aka.ms/new-console-template for more information
using Static;
using System;
using System.Globalization;

namespace Curso
{
    class Programa
    {
        static void Main(string[] args)
        {
            

            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine($"Circunferencia: {circ.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Volume: {volume.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor de Pi: {Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture)}");
        }

       
        
    }
}