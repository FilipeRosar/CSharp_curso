using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class ExercicioWhile1
    {
        static void main(string[] args)
        {
            while (true)
            {
                Console.Write("Digite a senha: ");
                int senha = int.Parse(Console.ReadLine());
                int senhaCorreta = 2020;
                if (senha !=  senhaCorreta)
                {
                    Console.WriteLine("Senha invalida");
                }
                else
                {
                    Console.WriteLine("Acesso Permitido");
                    break;
                }

            }


        }
    }
}
