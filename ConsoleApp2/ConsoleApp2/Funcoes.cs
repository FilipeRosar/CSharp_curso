﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Funcoes
    {
        static void main(string[] args)
        {
            Console.WriteLine("Digite 3 números: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            int resultado = Maior(n1, n2, n3);

            Console.WriteLine($"Maior é {resultado}");
            
        }
        static int Maior(int a, int b, int c)
        {
            int m;

            if (a > b && a > c)
            {
                m = a;
            }
            else if (b > c)
            {
                m = b;
            }
            else
            {
                m = c;
            }
            return m;
        }
    }

}
