using System.Globalization;

namespace Secao7
{
    internal class StringFunctionsProgram
    {
        public static void Run()
        {
            string original = "abcde FGHIJ ABC abc DEFG    ";

            string s1 = original.ToUpper();
            string s2 = original.ToLower();

            // Corta remove os espaços em branco no começo ou final da string
            string s3 = original.Trim();

            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");

            // Corta a string a partir do 3 index
            string s4 = original.Substring(3);
            // Corta a string a partir do 3ro index e limite a 5 caracteres
            string s5 = original.Substring(3, 5);

            // Substitui todo 'a' por 'x'
            string s6 = original.Replace('a', 'x');
            string s7 = original.Replace("abc", "xy");

            // Verifica se a string é vazia
            bool b1 = String.IsNullOrEmpty(original);
            // Verifica se a string é vazia ou um espaço em branco
            bool b2 = String.IsNullOrWhiteSpace(original);

            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("IndexOf('bc'): -" + n1);
            Console.WriteLine("LastIndexOf('bc'): -" + n2);
            Console.WriteLine("Substring(3): -" + s4 + "-");
            Console.WriteLine("Substring(3, 5): -" + s5 + "-");
            Console.WriteLine("Replace('a', 'x'): -" + s6 + "-");
            Console.WriteLine("Replace(\"abc\", \"xy\"): -" + s7 + "-");
            Console.WriteLine("IsNullOrEmpty: -" + b1);
            Console.WriteLine("IsNullOrWhiteSpace: -" + b2);

        }
    }
}
