using System;
using System.Globalization;


namespace ListExercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int quantidade = int.Parse(Console.ReadLine());

            List<Empregados> empregados = [];

            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine($"\nEmplyoee #{i + 1}");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


                empregados.Add(new Empregados(id, name, salary));
            }

            Console.Write("\nEnter the employee id that will have salary increase: ");
            int idSalarioAumento = int.Parse(Console.ReadLine());

            Empregados empregado = empregados.Find(e => e.EmpregadoId == idSalarioAumento);

            if (empregado != null)
            {
                Console.Write("\nEnter the porcentage: ");
                double porcentagem = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                empregado.SetSalario(porcentagem);
            }
            else
            {
                Console.WriteLine("This Id does not exist.");
            }

            Console.WriteLine("\nUpdated list of employees:");
            foreach (var item in empregados) 
            {
                Console.WriteLine(item);
            }
        }
    }
}