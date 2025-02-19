﻿
using Secao10_02.Entities;
using Secao10_02.Entities.Exceptions;

namespace Secao10_02
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.Write("Room number: ");
                int roomNumber = int.Parse(Console.ReadLine());

                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-out date (dd/MM/yyyy):");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());


                Reservation reservation = new(roomNumber, checkIn, checkOut);
                Console.WriteLine($"Reservarion: {reservation}");

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservarion: ");

                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-out date (dd/MM/yyyy):");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);

                Console.WriteLine($"Reservation: {reservation}");
            }
            catch (DomainException e)
            {
                Console.WriteLine($"Error in reservation: {e.Message}");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Format error: {e.Message}");
            }
            catch(Exception e)
            {
                Console.WriteLine($"Unexpected error: {e.Message}");
            }

        }

    }
}

