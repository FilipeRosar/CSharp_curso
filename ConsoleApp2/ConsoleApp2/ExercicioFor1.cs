using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class ExercicioFor1
    {
        static void main(string[] args)
        {
            Console.Write("Digite um número: ");
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i < x; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
               
            }
        }
    }
}
