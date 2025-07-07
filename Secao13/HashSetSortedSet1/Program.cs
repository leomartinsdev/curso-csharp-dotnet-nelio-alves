namespace Secao13.HashSetSortedSet1
{
    internal class Program
    {
        public static void Run()
        {
            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine(set.Contains("Notebook"));

            // Em sets não é possível usar For normal.
            foreach (string item in set)
            {
                Console.WriteLine(item);
            }
        }
    }
}
