using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void main(string[] args)
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine($"O número {numero} não é negativo");
            }
            else
            {
                Console.WriteLine($"O número {numero} é negativo");
            }
        }
    }
}