
using Secao12_Exercicio.Entities;
using Secao12_Exercicio.Service;
using System.Globalization;

namespace Secao12_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data: ");

            Console.Write("Number: ");
            string? accountNumberInput = Console.ReadLine();
            if (string.IsNullOrEmpty(accountNumberInput))
            {
                throw new ArgumentException("Account number cannot be empty");
            }
            int accountNumber = int.Parse(accountNumberInput);

            Console.Write("Date (dd/MM/yyyy): ");
            string? dateInput = Console.ReadLine();
            if (string.IsNullOrEmpty(dateInput))
            {
                throw new ArgumentException("Date cannot be null or empty");
            }
            DateTime date = DateTime.ParseExact(dateInput, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Console.Write("Contract value: ");
            string? contractValueInput = Console.ReadLine();
            if (string.IsNullOrEmpty(contractValueInput))
            {
                throw new ArgumentException("Contract value cannot be null or empty");
            }
            double contractValue = double.Parse(contractValueInput, CultureInfo.InvariantCulture);

            Console.Write("Enter number of installments: ");
            string? installmentsInput = Console.ReadLine();
            if (string.IsNullOrEmpty(installmentsInput))
            {
                throw new ArgumentException("Number of installments cannot be null or empty");
            }
            int installments = int.Parse(installmentsInput);

            Contract contract = new Contract(accountNumber, date, contractValue);
            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessContract(contract, installments);

            Console.WriteLine();

            Console.WriteLine("Installments: ");
            foreach (Installment installment in contract.Installments)
            {
                Console.WriteLine(installment);
            }
        }
    }
}