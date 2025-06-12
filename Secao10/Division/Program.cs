namespace Secao10.Division
{
    internal class Program
    {
        public static void Run()
        {
            try
            {
                int number1 = int.Parse(Console.ReadLine());
                int number2 = int.Parse(Console.ReadLine());

                int result = number1 / number2;

                Console.WriteLine(result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Divsion by zero is not allowed.");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Format error! {e.Message}");
            }
        }
    }
}
