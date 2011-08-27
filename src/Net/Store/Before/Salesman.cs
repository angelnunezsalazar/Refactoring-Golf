namespace Before
{
    public class Salesman : Employee
    {
        public int CommPor{ get; set; } //CommissionPorcentage

        public decimal MonQuo{ get; private set; } //MonthQuota

        public Salesman(string firstName, string lastName, decimal fixedSalary, int commPor)
            : base(firstName, lastName, fixedSalary)
        {
            this.CommPor = commPor;
        }

        public decimal CalculateNetSalary()
        {
            decimal addicionalBenefits = this.MonQuo * this.CommPor / 100;
            decimal pensionFounds = this.FixedSalary * 10 / 100;
            decimal tax = 0;
            if (FixedSalary > 3500)
                tax = FixedSalary * 5 / 100;
            return addicionalBenefits + FixedSalary - pensionFounds - tax;
        }

        /// <summary>
        /// Update the Month Quota
        /// </summary>
        /// <param name="addQuo">
        /// The addicional quota.
        /// </param>
        public void UpdateMonQuo(decimal addQuo)
        {
            MonQuo = MonQuo + addQuo;
        }
    }
}