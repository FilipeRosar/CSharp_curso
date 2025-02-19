

using Exercicio_sec9.Entities;
using System.Globalization;

namespace Exercicio_sec9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> productsList = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data: ");

                Console.Write("Common, used, imported ( c/u/i )? ");
                char tags = char.Parse(Console.ReadLine().ToLower());

                Console.Write("Name: ");
                    string productName = Console.ReadLine();

                Console.Write("Price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (tags == 'c')
                {
                    Product commonProduct = new Product(productName, productPrice);

                    productsList.Add(commonProduct);
                }
                else if (tags == 'u')
                {

                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());

                    Product usedProduct = new UsedProduct(productName, productPrice, manufactureDate);

                    productsList.Add(usedProduct);
                }
                else if (tags == 'i')
                {
                   
                    Console.Write("Customs Fee: ");
                    double customsFee = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                    Product importedProduct = new ImportedProduct(productName, productPrice, customsFee);

                    productsList.Add(importedProduct);

                    
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");
            foreach (var produts in productsList)
            {
                Console.WriteLine(produts.PriceTag());
            }
        }
    }
}