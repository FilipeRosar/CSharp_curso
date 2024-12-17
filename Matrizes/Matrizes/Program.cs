

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o número de colunas: ");
            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[n,n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Entre com os valores da matriz: ");

                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0;j < n; j++)
                {
                    mat[i,j] = int.Parse(values[j]);
                }
            }


           Console.WriteLine($"Main Diagonal: ");

            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i,i] + " ");

            }
            Console.WriteLine();

            int count = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0;j < n; j++)
                {
                    if (mat[i,j] < 0) {
                        count++;
                    }
                }
            }
            Console.Write($"Negative Numbers: {count}");


        }
    }
}