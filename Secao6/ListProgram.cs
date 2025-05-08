using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Secao6
{
    internal class ListProgram
    {
        public static void Run()
        {
            List<string> list = new List<string>();
            // ou = List<string> list = new()

            // ou  List<string> list = ["Gondor", "Rohan"...]

            // Adiciona um item ao final da lista: Add
            list.Add("Gondor");
            list.Add("Rohan");
            list.Add("Shire");
            list.Add("Hogwarts");
            list.Add("Metropolis");
            list.Add("King's Landing");
            list.Add("Rivendell");
            list.Add("Narnia");
            list.Add("Zion");

            // Adiciona um item na posição que quiser: Insert
            list.Insert(2, "Gotham");

            foreach (string city in list)
            {
                Console.WriteLine(city);
            }

            // Tamanho da lista: Count
            Console.WriteLine("List size: ", list.Count);

            // Encontra o primeiro (Find) ou último (FindLast) elemento que satisfaça um predicado
            string s1 = list.Find(x => x[0] == 'G');
            Console.WriteLine("First G: " + s1);

            string s2 = list.FindLast(x => x[0] == 'G');
            Console.WriteLine("Last G: " + s2);

            // Encontra a primeira (FindIndex) ou última (FindLastIndex) posição do elemento que satisfaça um predicado
            int pos1 = list.FindIndex(x => x[0] == 'G');
            Console.WriteLine("Index of first G: " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'G');
            Console.WriteLine("Index of last G: " + pos2);

            // Filtrar a lista baseada num predicado. Cria uma nova lista contendo só os elementos filtrados: FindAll
            List<string> filteredList = list.FindAll(x => x.Length == 5);
            foreach (string city in filteredList)
            {
                Console.WriteLine(city);
            }

            // Remover um item da lista que satisfaça uma condição: Remove
            list.Remove("Shire");
            Console.WriteLine("Lista atualizada: " + list);

            // Remover todos itens que satisfaçam uma condição: RemoveAll
            list.RemoveAll(x => x[0] == 'G');
            Console.WriteLine("Lista atualizada: " + list);

            // Remove um elemento pela posição dele: RemoveAt
            list.RemoveAt(0);
            Console.WriteLine("Lista atualizada: " + list);

            // Remover os elementos de uma faixa: RemoveRange
            list.RemoveRange(0, 5);
            Console.WriteLine("Lista atualizada: " + list);
        }
    }
}
