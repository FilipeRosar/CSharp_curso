
using Aula72;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = Calculator.Sum(1, 2);
            int a = 10;
            int triple;
            Calculator.Triple(a, out triple);

            Console.WriteLine(triple);
            Console.WriteLine(s1);
        }
    }
}