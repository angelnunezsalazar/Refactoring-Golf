package refactoringgolf.store;

public class Manager extends Employee {

	public Manager(String firstName, String lastName, float fixedSalary) {
		super(firstName, lastName, fixedSalary);
	}

	public float salaryAfterAdditionsAndDeductions() {
		float benefits = salaryBenefits();
		float pensionFounds = this.fixedSalary * 10 / 100;
		float tax = 0;
		if (fixedSalary > 3500)
			tax = fixedSalary * 5 / 100;
		return fixedSalary + benefits - pensionFounds - tax;
	}

	private float salaryBenefits() {
		return this.subordinates.size() * 20;
	}
}
