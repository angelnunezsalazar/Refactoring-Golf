namespace Before
{
    using System.Collections.Generic;
    using System.Linq;

    public abstract class Employee
    {
        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public decimal FixedSalary { get; private set; }

        public Employee Manager { get; internal set; }

        public string Street { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        /*
         * Only the managers have subordinates
         * but anyone could have a manager.
         */
        protected IList<Employee> subordinates = new List<Employee>();

        public IEnumerable<Employee> Subordinates
        {
            get { return subordinates.ToArray(); }
        }

        protected Employee(string firstName, string lastName, decimal fixedSalary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FixedSalary = fixedSalary;
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