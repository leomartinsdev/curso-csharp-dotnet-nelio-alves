namespace Secao11.Class133
{
    class Program
    {
        public static void Run()
        {
            string sourcePath = @"E:\Projetos DOTNET\file1.txt";
            string targetPath = @"E:\Projetos DOTNET\file2.txt";

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
                Console.WriteLine($"An error ocured: {e.Message}");
            }
        }
    }
}
