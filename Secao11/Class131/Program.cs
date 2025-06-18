using System.IO;

namespace Secao11.Class131
{
    class Program
    {
        public static void Run()
        {
            string path = @"E:\Projetos DOTNET\file1.txt";
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                //fs = new FileStream(path, FileMode.Open); -> Maneira 1
                //sr = new StreamReader(fs); -> Maneira 2

                sr = File.OpenText(path); // -> Maneira 2

                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            catch (IOException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
                //else if (fs != null) -> IF para a maneira 1.
                //{
                //    fs.Close();
                //}
            }
        }
    }
}
