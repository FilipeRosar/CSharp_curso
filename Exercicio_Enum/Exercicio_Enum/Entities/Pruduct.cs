
namespace Exercicio_Enum.Entities
{
    class Pruduct
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Pruduct() { }

        public Pruduct(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
