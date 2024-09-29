using POO;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa primeiraPessoa = new Pessoa();
            Pessoa segundaPessoa = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa ");
            Console.Write("Nome: ");
            primeiraPessoa.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            primeiraPessoa.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da Segunda Pessoa ");
            Console.Write("Nome: ");
            segundaPessoa.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            segundaPessoa.Idade = int.Parse(Console.ReadLine());

            if (primeiraPessoa.Idade > segundaPessoa.Idade)
            {
                Console.WriteLine($"A pessoa mais velha é {primeiraPessoa.Nome}");
            }
            else
            {
                Console.WriteLine($"A pessoa mais velha é {segundaPessoa.Nome}");
            }

            
        }
    }
}