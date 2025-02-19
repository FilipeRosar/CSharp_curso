using System.IO;

namespace Secao11_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\filip\Downloads\Cursos\text.txt";
            string targetPath = @"C:\Users\filip\Downloads\Cursos\text2.txt";

            try
            {
                FileInfo fileInfo = new(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred!");
                Console.WriteLine(e.Message);
            }
        }
    }
}