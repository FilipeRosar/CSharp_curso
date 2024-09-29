// See https://aka.ms/new-console-template for more information
using PooExercicio02;
using System;
using System.Globalization;

namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa primeiroFuncionario = new Pessoa();
            Pessoa segundaFuncionario = new Pessoa();

            Console.WriteLine("Dados do primeiro funcionário");
            
            Console.Write("Nome: ");
            primeiroFuncionario.Nome = Console.ReadLine();

            Console.Write("Salário: ");
            primeiroFuncionario.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário ");
            Console.Write("Nome: ");
            segundaFuncionario.Nome = Console.ReadLine();

            Console.Write("Salário: ");
            segundaFuncionario.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salarioMedia = (primeiroFuncionario.Salario + segundaFuncionario.Salario) / 2;

            Console.WriteLine($"Salário médio: {salarioMedia.ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}
