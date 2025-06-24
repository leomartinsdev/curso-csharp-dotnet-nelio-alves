﻿namespace Secao11.Class132
{
    class Program
    {
        public static void Run()
        {
            string path = @"E:\Projetos DOTNET\file1.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"An error ocured: {e.Message}");
            }
        }
    }
}
