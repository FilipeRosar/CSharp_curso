using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class For
    {
        static void main(string[] args)
        {
            Console.Write("Quantos números inteiros você vai digitar? ");
            int N = int.Parse(Console.ReadLine());
            int soma = 0;
            for (int i = 1; i <= N; i++)
            {
                Console.Write($"Valor #{i}: ");
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }
            Console.WriteLine($"Soma = {soma}");
        }
    }
}
