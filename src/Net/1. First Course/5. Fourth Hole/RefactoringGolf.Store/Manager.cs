namespace RefactoringGolf.Store
{
    using System.Collections.Generic;
    using System.Linq;

    public class Manager : Employee
    {
        protected IList<Employee> subordinates = new List<Employee>();

        public Manager(string firstName, string lastName, decimal fixedSalary)
            : base(firstName, lastName, fixedSalary)
        {
        }

        protected override decimal SalaryBenefits()
        {
            return this.subordinates.Count * 20;
        }

        public IEnumerable<Employee> Subordinates
        {
            get { return subordinates.ToArray(); }
        }

        public void AddSubordinate(Employee subordinate)
        {
            subordinates.Add(subordinate);
            subordinate.Manager = this;
        }

        public void RemoveSubordinate(Employee subordinate)
        {
            subordinates.Remove(subordinate);
            subordinate.Manager = null;
        }
    }
}