using System;
using System.Globalization;

namespace ExercicioProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Entre os dados do produto: ");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto primeiroProduto = new(nome, preco, quantidade);

            Console.WriteLine($"Dados do produto: {primeiroProduto}\n");

            Console.Write("Digite o número de produtos a ser adicionado: ");
            int qte = int.Parse(Console.ReadLine());
            primeiroProduto.AdicionarProdutos(qte);
            Console.WriteLine($"Dados atualizados {primeiroProduto}\n");

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            int qtd = int.Parse(Console.ReadLine());
            primeiroProduto.RemoverProdutos(qtd);
            Console.WriteLine($"Dados atualizados {primeiroProduto}");
        }
    }
}
