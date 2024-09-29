using ExercicioBanco;
using System;
using System.Globalization;

namespace Curso{
    class Program
    {
        static void Main(string[] args)
        {
            double deposito = 0;
            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n):");
            char confirmacao = char.Parse(Console.ReadLine().ToUpper());

            if (confirmacao == 'S')
            {
                Console.Write("Entre com o valor inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                deposito += depositoInicial;
            }
            
            Conta pessoaConta = new(numero,titular, deposito);

            Console.WriteLine($"\nDados da conta:\n{pessoaConta}");

            Console.Write("\nEntre um valor para depósito: ");
            deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            pessoaConta.Deposito(deposito);

            Console.WriteLine($"\nDados da conta atualizados:\n{pessoaConta}");

            Console.Write("\nEntre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            pessoaConta.Saque(saque);
            Console.WriteLine($"\nDados da conta atualizados:\n{pessoaConta}");







        }
    }
}