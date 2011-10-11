namespace RefactoringGolf.Store
{
    public class Manager : Employee
    {
        public Manager(string firstName, string lastName, decimal fixedSalary)
            : base(firstName, lastName, fixedSalary)
        {
        }
        
        public decimal SalaryAfterAdditionsAndDeductions()
        {
            decimal benefits = SalaryBenefits();
            decimal pensionFounds = this.FixedSalary * 10 / 100;
            decimal tax = 0;
            if (FixedSalary > 3500)
                tax = FixedSalary * 5 / 100;
            return this.FixedSalary + benefits - pensionFounds - tax;
        }

        private decimal SalaryBenefits()
        {
            return this.subordinates.Count * 20;
        }
    }
}