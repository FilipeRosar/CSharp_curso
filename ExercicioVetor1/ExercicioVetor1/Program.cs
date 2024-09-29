using ExercicioVetor1;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Alunos[] vect = new Alunos[10];

            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Aluguel #{i + 1}:\n");
                Console.Write("Nome: ");
                string name = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Quarto: ");
                int quartos = int.Parse(Console.ReadLine());
                vect[quartos] = new Alunos(name, email);

                Console.WriteLine();


            }
            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine($"{i}: {vect[i]}");
                }
            }




        }

    }
}
