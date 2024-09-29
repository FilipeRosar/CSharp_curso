using System;
using System.Collections.Generic;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = [];

            list.Add("Filipe");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Ana");
            list.Insert(3, "Marco");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"List Count: {list.Count}");

            string s1 = list.Find(static x => x[0] == 'A');
            Console.WriteLine($"First 'A': {s1}");

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine($"Last 'A': {s2}");

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine($"First postition 'A': {pos1}");

            int post2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine($"Last position 'A': {post2}");

            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("-----------");
            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }

            list.Remove("Bob");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("-----------");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }

    }

}
