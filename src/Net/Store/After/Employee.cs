namespace After
{
    public abstract class Employee
    {
        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public decimal FixedSalary { get; private set; }

        public Manager Manager { get; internal set; }

        public Address Address { get; set; }

        protected Employee(string firstName, string lastName, decimal fixedSalary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FixedSalary = fixedSalary;
        }

        public decimal CalculateNetSalary()
        {
            decimal addicionalBenefits = CalculateAddicionalBenefits();
            decimal pensionFounds = this.FixedSalary * 10 / 100;
            decimal tax = 0;
            if (this.FixedSalary > 3500)
                tax = this.FixedSalary * 5 / 100;
            return addicionalBenefits + this.FixedSalary - pensionFounds - tax;
        }

        protected abstract decimal CalculateAddicionalBenefits();
    }
}