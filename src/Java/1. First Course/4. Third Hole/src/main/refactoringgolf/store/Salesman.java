package refactoringgolf.store;

public class Salesman extends Employee {

	private int commPor; // CommissionPorcentage
	private float monQuo; // MonthQuota

	public Salesman(String firstName, String lastName, float fixedSalary, int commPor){
    	super(firstName, lastName, fixedSalary);
        this.commPor = commPor;
    }

	public void setCommPor(int commPor) {
		this.commPor = commPor;
	}

	public int getCommPor() {
		return commPor;
	}

	public float getMonQuo() {
		return monQuo;
	}

	public float netSalary() {
		float addicionalBenefits = monQuo * commPor / 100;
		float pensionFounds = fixedSalary * 10 / 100;
		float tax = 0;
		if (fixedSalary > 3500)
			tax = fixedSalary * 5 / 100;
		return addicionalBenefits + fixedSalary - pensionFounds - tax;
	}

	/**
	 * @param addQuo
	 *            The addicional quota
	 */
	public void updateMonQuo(float addQuo) {
		monQuo = monQuo + addQuo;
	}
}
