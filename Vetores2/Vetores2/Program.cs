using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com a quantidade de produtos: ");
            int n = int.Parse(Console.ReadLine());

            Products[] vect = new Products[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Produto: ");
                string name = Console.ReadLine();
                Console.Write("Preço: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Products { Name = name, Price = price };
            }
            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i].Price;
            }
            double avg = sum / n;
            Console.WriteLine($"Preço médio = {avg:F2}");

        }
    }
}