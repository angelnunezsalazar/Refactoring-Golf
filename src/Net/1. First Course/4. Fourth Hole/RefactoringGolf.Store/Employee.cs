namespace RefactoringGolf.Store
{
    public abstract class Employee
    {
        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public decimal FixedSalary { get; private set; }

        public Employee Manager { get; internal set; }

        public string Street { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        protected Employee(string firstName, string lastName, decimal fixedSalary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FixedSalary = fixedSalary;
        }

        public decimal NetSalary()
        {
            return this.FixedSalary + SalaryBenefits() - PensionFounds() - Tax();
        }

        private decimal Tax()
        {
            decimal tax = 0;
            if (this.FixedSalary > 3500)
                tax = this.FixedSalary*5/100;
            return tax;
        }

        private decimal PensionFounds()
        {
            return this.FixedSalary * 10 / 100;
        }

        protected abstract decimal SalaryBenefits();
    }
}