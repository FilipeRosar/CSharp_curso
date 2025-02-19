

using Secao11_Exercicio.Entities;
using System.Globalization;

namespace Secao11_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Entre com o caminho do arquivo: ");
                string sourcePath = Console.ReadLine();

                string[] lines = File.ReadAllLines(sourcePath);

                string sourceFolderPath = Path.GetDirectoryName(sourcePath);
                string targetFolderPath = Path.Combine(sourceFolderPath, "out");
                string targetFilePath = Path.Combine(targetFolderPath, "summary.csv");

                Directory.CreateDirectory(targetFolderPath);

                using (StreamWriter sw = File.AppendText(targetFilePath))
                {
                    foreach (string line in lines)
                    {
                        string[] space = line.Split(',');
                        string name = space[0];
                        double price = double.Parse(space[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(space[2]);

                        Itens itens = new Itens(name, price, quantity);

                        sw.WriteLine($"{itens.ProductName}, {itens.GetTotal().ToString("F2", CultureInfo.InvariantCulture)}");
                    }
                }
                Console.WriteLine("Arquivo criado com sucesso!");
            }
            catch (IOException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            
        }

    }
}
}