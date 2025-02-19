using System.IO;

namespace Secao11_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\filip\Downloads\Cursos\C#\myfolder";

            try
            {
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS: ");
                foreach (string folderName in folders)
                {
                    Console.WriteLine(folderName);
                }
                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES: ");
                foreach (string filesName in files)
                {
                    Console.WriteLine(filesName);
                }

                Directory.CreateDirectory(path + "\\newFolder");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}