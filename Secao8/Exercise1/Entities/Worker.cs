using Secao8.Exercise1.Entities.Enums;

namespace Secao8.Exercise1.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Deparment { get; set; }
        public List<HourContract> Contracts { get; set; } = [];
        // ou: public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker() { }

        public Worker(string name, WorkerLevel level, double baseSalary, Department deparment) // Aqui não passamos as associações de 1 para muitos.
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Deparment = deparment;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;

            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }

            return sum;
        }
    }
}
