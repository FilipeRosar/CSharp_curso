using Secao12_01.Entities;
using Secao12_01.Services;
using System.Globalization;

namespace Secao12_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental date: ");
            Console.WriteLine();
            Console.Write("Car Model: ");
            string carModel = Console.ReadLine();

            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture) ;

            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Enter price per hour: ");
            double hour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("Enter price per day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(carModel));

            RentalServices rentalService = new RentalServices(hour, day, new BrazilTaxServices());

            rentalService.ProcessInvoice(carRental);
            Console.WriteLine();
            Console.WriteLine("INVOICE: ");
            Console.WriteLine(carRental.Invoice);
        }
    }
}