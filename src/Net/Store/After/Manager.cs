namespace After
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

        protected override decimal CalculateAddicionalBenefits()
        {
            return this.subordinates.Count * 20;
        }

        public IEnumerable<Employee> Subordinates
        {
            get { return this.subordinates.ToArray(); }
        }

        public void AddSubordinate(Employee subordinate)
        {
            this.subordinates.Add(subordinate);
            subordinate.Manager = this;
        }

        public void RemoveSubordinate(Employee subordinate)
        {
            this.subordinates.Remove(subordinate);
            subordinate.Manager = null;
        }
    }
}