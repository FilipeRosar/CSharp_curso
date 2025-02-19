
using Secao12_02.Model.Enums;

namespace Secao12_02.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
