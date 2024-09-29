// See https://aka.ms/new-console-template for more information
using System;


namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void main(string[] args)
        {
            Console.Write("Digite a hora inicial do jogo: ");
            int horaInicial = int.Parse(Console.ReadLine());

            Console.Write("Digite a hora que acabou: ");
            int horaFim = int.Parse(Console.ReadLine());

            int duracao;

            if (horaInicial < horaFim)
            {
                duracao = horaFim - horaInicial;
            }
            else if (horaInicial > horaFim)
            {
                duracao = 24 - horaInicial + horaFim;
            }
            else
            {
                duracao = 24;
            }
            
            Console.WriteLine(duracao);
        }
    }
}
