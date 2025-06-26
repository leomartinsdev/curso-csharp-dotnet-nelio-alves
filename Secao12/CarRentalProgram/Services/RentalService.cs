using Secao12.CarRentalProgram.Entities;

namespace Secao12.CarRentalProgram.Services
{
    internal class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        private BrazilTaxService _brazilTexService = new BrazilTaxService();

        public RentalService(double pricePerHour, double pricePerDay)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basePayment = 0.0;

            if (duration.TotalHours <= 12.0)
            {
                basePayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basePayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _brazilTexService.Tax(basePayment);

            carRental.Invoice = new Invoice(basePayment, tax);


        }
    }
}
