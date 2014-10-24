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
            decimal benefits = SalaryBenefits();
            decimal pensionFounds = this.FixedSalary * 10 / 100;
            decimal tax = 0;
            if (this.FixedSalary > 3500)
                tax = this.FixedSalary * 5 / 100;
            return this.FixedSalary + benefits - pensionFounds - tax;
        }

        protected abstract decimal SalaryBenefits();
    }
}