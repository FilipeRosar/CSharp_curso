﻿using ExercicioNotas;
using System;
using System.Globalization;

namespace Curso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alunos aluno = new();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Nota Final: {aluno.NotaFinal().ToString("F2")}");

            if (aluno.Aprovado())
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
                Console.WriteLine($"Faltaram {aluno.Restantes().ToString("F2", CultureInfo.InvariantCulture)} pontos");
               
            }
        }
    }
}