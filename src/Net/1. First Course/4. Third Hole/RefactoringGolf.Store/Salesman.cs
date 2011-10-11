namespace RefactoringGolf.Stack
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

        public decimal NetSalary()
        {
            decimal benefits = this.MonthQuota * this.CommissionPorcentage / 100;
            decimal pensionFounds = this.FixedSalary * 10 / 100;
            decimal tax = 0;
            if (FixedSalary > 3500)
                tax = FixedSalary * 5 / 100;
            return this.FixedSalary + benefits - pensionFounds - tax;
        }

        public void UpdateMonthQuota(decimal addQuota)
        {
            MonthQuota = MonthQuota + addQuota;
        }
    }
}