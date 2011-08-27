namespace After
{
    public class Salesman : Employee
    {
        public int CommissionPorcentage { get; set; }

        public decimal MonthQuota { get; private set; }

        public Salesman(string firstName, string lastName, decimal fixedSalary, int commissionPorcentage)
            : base(firstName, lastName, fixedSalary)
        {
            this.CommissionPorcentage = commissionPorcentage;
        }

        protected override decimal CalculateAddicionalBenefits()
        {
            return this.MonthQuota * this.CommissionPorcentage / 100;
        }

        public void UpdateMonthQuota(decimal additionalQuota)
        {
            MonthQuota = MonthQuota + additionalQuota;
        }
    }
}