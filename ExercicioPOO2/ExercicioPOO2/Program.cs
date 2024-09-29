using ExercicioPOO2;
using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa funcionario = new();

            Console.WriteLine("Entre com os dados do funcionário: ");

            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();

            Console.Write("Salário Bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            funcionario.SalarioLiquido();

            Console.WriteLine(funcionario);

            Console.WriteLine($"Digite a porcentagem para aumentar o salário: ");
            double aumentoSalario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            funcionario.AumentarSalario(aumentoSalario);

            Console.WriteLine(funcionario);

        }
    }
}