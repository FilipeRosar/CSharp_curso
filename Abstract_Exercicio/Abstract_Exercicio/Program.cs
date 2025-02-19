

using Abstract_Exercicio.Entities;
using System.Globalization;

namespace Abstract_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {
                Console.Write("Individual or company (i/c)? ");
                char indiOrComp = char.Parse(Console.ReadLine().ToLower());

                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (indiOrComp == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Individual(name, anualIncome, healthExpenditures));
                }
                else if (indiOrComp == 'c')
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());

                    list.Add(new Company(name, anualIncome, employees));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");

            double sum = 0.0;
            foreach (TaxPayer taxPayer in list)
            {
                double tax = taxPayer.Tax();
                Console.WriteLine($"{taxPayer.Name}: $ {tax.ToString("F2", CultureInfo.InvariantCulture)}");
                sum += tax;
            }

            Console.WriteLine();

            Console.Write($"TOTAL TAXES: {sum.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}