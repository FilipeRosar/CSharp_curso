// See https://aka.ms/new-console-template for more information
using System;

namespace Cursos
{
    class Calculadora
    {
        public double Pi = 3.14;

        public double Circunferencia (double r)
        {
            return 2.0 * Pi * r;
        }
        public double Volume(double r)
        {
            return 4.0 / 3.0 * Math.Pow(r, 3);
        }
        static void Main(string[] args)
        {
            
        }
    }
}
