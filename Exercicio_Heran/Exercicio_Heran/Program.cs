
using Exercicio_Heran.Entities;
using System.Globalization;

namespace Exercicio_Heran
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> lista = new();

            Console.Write("Enter the number of employee: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data: ");

                Console.Write("OutSourcered (y/n)? ");
                char ch = char.Parse(Console.ReadLine().ToLower());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int hour = int.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new OutsourcedEmployee(name, hour, valuePerHour, additionalCharge));
                }
                else
                {
                    lista.Add(new Employee(name, hour, valuePerHour));
                }


            }
                Console.WriteLine();
                Console.WriteLine("PAYMENTS: ");

                foreach (Employee emp in lista)
                {
                    Console.WriteLine($"{emp.Name} - ${emp.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
                }
        }
    }
}
