package refactoringgolf.store;

public class Manager extends Employee {
	
	public Manager(String firstName, String lastName, float fixedSalary)
	{
		super(firstName, lastName, fixedSalary);
	}

	public float salaryAfterAdditionsAndDeductions() {
		float addicionalBenefits = addicionalBenefits();
		float pensionFounds = this.fixedSalary * 10 / 100;
		float tax = 0;
		if (fixedSalary > 3500)
			tax = fixedSalary * 5 / 100;
		return addicionalBenefits + fixedSalary - pensionFounds - tax;
	}

	private float addicionalBenefits() {
		return this.subordinates.size() * 20;
	}
}
