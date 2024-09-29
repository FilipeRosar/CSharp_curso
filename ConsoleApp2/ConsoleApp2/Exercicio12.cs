using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Exercicio12
    {
        static void main(string[] args)
        {
            Console.Write("Digite um valor: ");
            double valor = double.Parse(Console.ReadLine());

            if (valor >= 0 && valor <= 25.00)
            {
                Console.WriteLine("Intervalo [ 0,25 ]");
            }
            else if (valor >= 25.01 && valor <= 50.00)
            {
                Console.WriteLine("Intervalo [ 25,50 ]");
            }
            else if (valor >= 50.01 && valor <= 75.00)
            {
                Console.WriteLine("Intervalo [ 50, 75 ]");
            }
            else if (valor >= 75.01 && valor <= 100)
            {
                Console.WriteLine("Intervalo [ 75,100 ]");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }
        }
    }
}
