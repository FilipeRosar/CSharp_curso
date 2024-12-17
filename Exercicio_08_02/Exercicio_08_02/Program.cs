

using Exercicio_08_02.Entities;

namespace Exercicio_08_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new("Have a nice trip!");

            Comment c2 = new("Wow that's awesome");

            Post p1 = new(DateTime.Parse("21/05/2018 13:05:44"),
                "Traveling to New Zealand",
                "I'm going to visit this wonderful country",
                12);

            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new("Good night.");
            Comment c4 = new("May the Force be with you");

            Post p2 = new(
                DateTime.Parse("28/07/2018 23:14:19"),
                "Good Night, guys",
                "See you tomorrow",
                5);
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}