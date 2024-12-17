
using System.Globalization;

namespace Exercicio_Enum.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Pruduct Pruduct { get; set; }

        public OrderItem() { }

        public OrderItem(int quantity, double price, Pruduct pruduct)
        {
            Quantity = quantity;
            Price = price;
            Pruduct = pruduct;
            
        }

        public double SubTotal()
        {
            return Price * Quantity;
        }
        public override string ToString()
        {
            return $"{Pruduct.Name}, ${Price.ToString("F2",CultureInfo.InvariantCulture)}," +
                $"Quantity: {Quantity}, Subtotal: ${SubTotal().ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
}
