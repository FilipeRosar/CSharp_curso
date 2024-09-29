using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Exercicio13
    {
        static void main(string[] args)
        {
            Console.Write("Digite o seu sálario: ");
            double salario = double.Parse(Console.ReadLine());

            double imposto;

            if (salario <= 2000.00)
            {
                imposto = 0.0;
            }
            else if (salario <= 3000.00)
            {
                imposto = (salario - 2000) * 0.08;
            }
            else if (salario <= 4500.00)
            {
                imposto = (salario - 3000) * 0.18 + 1000.0 * 0.08;
            }
            else
            {
                imposto = (salario - 4500) * 0.28 + 1500.00 * 0.18 + 1000.00 * 0.08;
            }
            if (imposto == 0)
            {
                Console.WriteLine("Isento");
            }
            Console.WriteLine($"R$ {imposto:F2}");
        }
    }
}
