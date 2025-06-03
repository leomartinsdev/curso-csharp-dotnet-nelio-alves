using System.Globalization;

namespace Secao9.Exercise1.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct() { }

        public ImportedProduct(double customsFee, string name, double price) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public override string PriceTag()
        {
            return base.PriceTag() + $" Customs fee: $ {CustomsFee.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
