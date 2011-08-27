namespace After.Tests
{
    using After;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ManagerTests
    {
        [TestMethod]
        public void CalculateTheNetSalaryWhenFixedSalaryIsUnderTheMinimumTax()
        {
            int fixedSalary = 3000;
            Manager manager = CreateManager(fixedSalary);

            Assert.AreEqual(2700, manager.CalculateNetSalary());
        }

        [TestMethod]
        public void CalculateTheNetSalaryWhenFixedSalaryIsOverTheMinimumTax()
        {
            int fixedSalary = 5000;
            Manager manager = CreateManager(fixedSalary);

            Assert.AreEqual(4250, manager.CalculateNetSalary());
        }

        [TestMethod]
        public void CalculateTheNetSalaryWhenBenefits()
        {
            int fixedSalary = 3000;
            Manager manager = CreateManager(fixedSalary);
            manager.AddSubordinate(CreateSubordinate());

            Assert.AreEqual(2720, manager.CalculateNetSalary());
        }

        private Manager CreateManager(int fixedSalary)
        {
            return new Manager("Carlos", "Rodriguez", fixedSalary);
        }

        private Salesman CreateSubordinate()
        {
            return new Salesman("Miguel", "Gonzales", 2000, 2);
        }
    }
}