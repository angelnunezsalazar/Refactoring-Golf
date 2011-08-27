namespace After.Tests
{
    using After;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class SalesmanTests
    {
        [TestMethod]
        public void CalculateTheNetSalaryWhenFixedSalaryIsUnderTheMinimumTax()
        {
            int fixedSalary = 3000;
            Salesman salesman = CreateSalesman(fixedSalary);

            Assert.AreEqual(2700, salesman.CalculateNetSalary());
        }

        [TestMethod]
        public void CalculateTheNetSalaryWhenFixedSalaryIsOverTheMinimumTax()
        {
            int fixedSalary = 5000;
            Salesman salesman = CreateSalesman(fixedSalary);

            Assert.AreEqual(4250, salesman.CalculateNetSalary());
        }

        [TestMethod]
        public void CalculateTheNetSalaryWhenHaveMonthQuota()
        {
            int fixedSalary = 3000;
            Salesman salesman = CreateSalesman(fixedSalary);
            salesman.UpdateMonthQuota(1000);

            Assert.AreEqual(2800, salesman.CalculateNetSalary());
        }

        private Salesman CreateSalesman(int fixedSalary)
        {
            return new Salesman("Carlos", "Rodriguez", fixedSalary, 10);
        }
    }
}