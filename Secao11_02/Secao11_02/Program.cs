using System.IO;


namespace Secao11_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\filip\Downloads\Cursos\text.txt";
            string targetPath = @"C:\Users\filip\Downloads\Cursos\text1.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred ");
                Console.WriteLine(e.Message);
            }
            //try
            //{

            //    using StreamReader sr = File.OpenText(path);
            //    while (!sr.EndOfStream)
            //    {
            //        string line = sr.ReadLine();
            //        Console.WriteLine(line);
            //    }
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine("An error occurred");
            //    Console.WriteLine(e.Message);
            //}

            //FileStream fs = null;
            //StreamReader sr = null;

            //try
            //{
            //    sr = File.OpenText(path);
            //    while (!sr.EndOfStream)
            //    {
            //        string line = sr.ReadLine();
            //        Console.WriteLine(line);
            //    }
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine("An error accurred.");
            //    Console.WriteLine(e.Message);
            //}
            //finally
            //{
            //    sr?.Close();

            //}
        }
    }
}