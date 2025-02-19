
using Secao12_02.Model.Entities;
using Secao12_02.Model.Enums;

namespace Secao12_02
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape shape_1 = new Circle() { Radius = 2.0, Color = Color.Black };
            IShape shape_2 = new Rectangle() { Width = 3.5, Height = 4.2, Color = Color.White };

            Console.WriteLine(shape_1);
            Console.WriteLine(shape_2);
        }
    }
}