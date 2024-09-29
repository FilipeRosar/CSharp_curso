using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Exercicio11
    {
        static void main(string[] args)
        {
            Console.WriteLine("Código     Especificação     Preço\n" +
                "1      Cachorro-Quente       R$ 4,00\n" +
                "2      X-Salada              R$ 4,50\n" +
                "3      X-Bacon               R$ 5,00\n" +
                "4      Torrada simples       R$ 2,00\n" +
                "5      Refrigerante          R$ 1,50");
            Console.Write("Digite o código do produto e a quantidade: ");
            string[] vet = Console.ReadLine().Split(' ');
            int codigoProduto = int.Parse(vet[0]);
            int quantidadeProduto = int.Parse(vet[1]);
            double precoProduto = 0.0;


            if (codigoProduto == 1)
            {
                precoProduto = 4.00;
            }
            else if (codigoProduto == 2)
            {
                precoProduto = 4.50;
            }
            else if (codigoProduto == 3)
            {
                precoProduto = 5.00;
            }
            else if (codigoProduto == 4)
            {
                precoProduto = 2.00;
            }
            else if (codigoProduto == 5)
            {
                precoProduto = 1.50;
            }
            else
            {
                Console.WriteLine("Error");
            }

            double total = precoProduto * quantidadeProduto;

            Console.WriteLine($"Total: R$ {total.ToString("F2")}");
        }
    }
}
