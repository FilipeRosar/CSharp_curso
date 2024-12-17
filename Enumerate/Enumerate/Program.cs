using Enumerate.Entities;
using Enumerate.Entities.Enums;
using System;

namespace Enumerate
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new()
            {
                Id = 1000,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPaymant
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPaymant.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(os);

            Console.WriteLine(txt);
            
        }
    }
}