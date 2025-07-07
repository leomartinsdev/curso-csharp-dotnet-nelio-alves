namespace Secao13.HashSetSortedSet2
{
    internal class Program
    {
        public static void Run()
        {
            SortedSet<int> sortedSet = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
            SortedSet<int> sortedSet2 = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            // union -> insere todos elementos do set2 que não estejam no set3.
            SortedSet<int> sortedSet3 = new SortedSet<int>(sortedSet);
            sortedSet3.UnionWith(sortedSet2);
            PrintCollection(sortedSet3);

            // intersection -> cria um set com os elementos que estão em ambos os conjuntos.
            SortedSet<int> sortedSet4 = new SortedSet<int>(sortedSet);
            sortedSet4.IntersectWith(sortedSet2);
            PrintCollection(sortedSet4);

            // Difference -> set1 excluidos os elementos que estão no set2.
            SortedSet<int> sortedSet5 = new SortedSet<int>(sortedSet);
            sortedSet5.ExceptWith(sortedSet2);
        }

        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T obj in collection)
            {
                Console.WriteLine($"{obj} ");
            }
            Console.WriteLine();
        }
    }
}
