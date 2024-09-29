using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class ExercicioWhile2
    {
        static void main(string[] args)
        {
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            Console.Write("1. Alcool\n2. Gasolina\n3. Diesel\n4. Fim\n");
            int opcao = int.Parse(Console.ReadLine());
            while (opcao != 4)
            {
                if (opcao == 1)
                {
                    alcool += 1;
                }
                else if (opcao == 2)
                {
                    gasolina += 1;
                }
                else if (opcao == 3)
                {
                    diesel += 1;
                }
                else if (opcao == 4)
                {
                    break;
                }
                opcao = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Alcool: {alcool}");
            Console.WriteLine($"Gasolina: {gasolina}");
            Console.WriteLine($"Diesel: {diesel}");
            Console.WriteLine("Muito Obrigado!");

        }
    }
}
