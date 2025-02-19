
namespace Secao11_Exercicio.Entities
{
    class Itens
    {
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public int ProductQuantity { get; set; }

        public Itens() { }
        public Itens(string productName, double productPrice, int productQuantity)
        {
            ProductName = productName;
            ProductPrice = productPrice;
            ProductQuantity = productQuantity;
        }

        public double GetTotal()
        {
            return ProductQuantity * ProductPrice;
        }
    }
}
