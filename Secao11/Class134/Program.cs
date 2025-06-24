using System;
using System.IO;
using System.Collections.Generic;

namespace Secao11.Class134
{
    class Program
    {
        public static void Run()
        {
            string path = @"E:\Projetos DOTNET\testfolder";

            try
            {
                // Lista pastas
                IEnumerable<string> folder = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS: ");

                foreach (string item in folder)
                {
                    Console.WriteLine(item);
                }


                // Lista arquivos nas pastas
                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES: ");

                foreach (string item in files)
                {
                    Console.WriteLine(item);
                }

                // Cria pasta
                Directory.CreateDirectory(path + "\\newfolder");
                Directory.CreateDirectory(path + @"\newfolder2");
            }
            catch (IOException e)
            {
                Console.WriteLine($"An error ocured: {e.Message}");
            }
        }
    }
}
