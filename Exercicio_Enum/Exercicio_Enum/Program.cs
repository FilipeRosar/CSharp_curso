using Exercicio_Enum.Entities;
using Exercicio_Enum.Entities.Enum;
using System.Globalization;

namespace Exercicio_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente date: ");
            Console.Write("Name: ");
            
            string clientName = Console.ReadLine();

            Console.Write("Email: ");
            string clientEmail = Console.ReadLine();

            Console.Write("Birth Date (DD/MM/YYYY): ");
            DateTime clientBirthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new(clientName,clientEmail,clientBirthDate);
            Order order = new(DateTime.Now,status, client);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {

                Console.WriteLine($"\nEnter #{i+1} item data: ");

                Console.Write("Product Name: ");
                string pruductName = Console.ReadLine();

                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Pruduct pruduct = new(pruductName, productPrice);
                OrderItem orderItem = new(quantity, productPrice, pruduct);
                order.AddItem(orderItem);

            }

            Console.WriteLine("ORDER SUMMARY: ");

            Console.WriteLine(order);


        }
    }
}