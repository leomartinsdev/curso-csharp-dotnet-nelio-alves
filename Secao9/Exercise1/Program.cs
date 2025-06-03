using Secao9.Exercise1.Entities;
using System.Globalization;

namespace Secao9.Exercise1
{
    internal class Program
    {
        public static void Run()
        {
            List<Product> products = new List<Product>();
            Console.Write("Enter the number of products: ");
            int numberOfProducts = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfProducts; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, used or imported (c/u/i? ");
                string productType = Console.ReadLine();

                Console.Write("Name: ");
                string productName = Console.ReadLine();

                Console.Write("Price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (productType == "i")
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    products.Add(new ImportedProduct(customsFee, productName, productPrice));
                }
                else if (productType == "u")
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    products.Add(new UsedProduct(manufactureDate, productName, productPrice));
                }
                else
                {
                    products.Add(new Product(productName, productPrice));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach (Product product in products)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
