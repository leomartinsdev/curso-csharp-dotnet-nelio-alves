﻿namespace Secao11.Class130
{
    class Program
    {
        public static void Run()
        {
            string sourcePath = @"E:\Projetos DOTNET\file1.txt";
            string targetPath = @"E:\Projetos DOTNET\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);

                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"Error occured: {e.Message}");
            }
        }
    }
}
