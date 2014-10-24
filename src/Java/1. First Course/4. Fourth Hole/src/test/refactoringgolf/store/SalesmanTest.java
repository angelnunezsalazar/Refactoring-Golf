package refactoringgolf.store;

import static org.junit.Assert.assertEquals;

import org.junit.Test;

import refactoringgolf.store.Salesman;

public class SalesmanTest {

	@Test
	public void calculateTheNetSalaryWhenFixedSalaryIsUnderTheMinimumTax() {
		int fixedSalary = 3000;
		Salesman salesman = createSalesman(fixedSalary);

		assertEquals(2700, salesman.netSalary(), 0);
	}

	@Test
	public void calculateTheNetSalaryWhenFixedSalaryIsOverTheMinimumTax() {
		int fixedSalary = 5000;
		Salesman salesman = createSalesman(fixedSalary);

		assertEquals(4250, salesman.netSalary(), 0);
	}

	@Test
	public void calculateTheNetSalaryWhenHaveMonthQuota() {
		int fixedSalary = 3000;
		Salesman salesman = createSalesman(fixedSalary);
		salesman.updateMonthQuota(1000);

		assertEquals(2800, salesman.netSalary(), 0);
	}

	private Salesman createSalesman(int fixedSalary) {
		return new Salesman("Carlos", "Rodriguez", fixedSalary, 10);
	}

}
