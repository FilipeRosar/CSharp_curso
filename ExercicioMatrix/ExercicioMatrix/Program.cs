using System;


namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de colunas e quantidade de linhas: ");
            string[] linha = Console.ReadLine().Split(' ');

            int m = int.Parse(linha[0]);
            int n = int.Parse(linha[1]);

            int[,] mat = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                Console.WriteLine($"Digite {n} números: ");
                string[] value = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(value[j]);
                }
            }

            Console.Write("Digite um número para localização: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] == x)
                    {
                        Console.WriteLine($"Position {i},{j}: ");
                        if (j > 0)
                        {
                            Console.WriteLine($"Left: {mat[i, j - 1]}");
                        }
                        if (i > 0)
                        {
                            Console.WriteLine($"Up: {mat[i - 1, j]}");
                        }
                        if (j < n - 1)
                        {
                            Console.WriteLine($"Right: {mat[i, j + 1]}");
                        }
                        if (i < m - 1)
                        {
                            Console.WriteLine($"Down: {mat[i + 1, j]}");
                        }
                    }
                }
            }
        }
    }
}