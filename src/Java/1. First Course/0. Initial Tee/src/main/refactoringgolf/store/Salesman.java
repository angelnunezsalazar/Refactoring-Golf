package refactoringgolf.store;

public class Salesman extends Employee {

	private int commissionPorcentage;
	private float monthQuota;

	public Salesman(String firstName, String lastName, float fixedSalary, int commissionPorcentage){
    	super(firstName, lastName, fixedSalary);
        this.commissionPorcentage = commissionPorcentage;
    }

	public void setCommissionPorcentage(int commissionPorcentage) {
		this.commissionPorcentage = commissionPorcentage;
	}

	public int getCommissionPorcentage() {
		return commissionPorcentage;
	}

	public float getMonthQuota() {
		return monthQuota;
	}

	public float netSalary() {
		float benefits = monthQuota * commissionPorcentage / 100;
		float pensionFounds = fixedSalary * 10 / 100;
		float tax = 0;
		if (fixedSalary > 3500)
			tax = fixedSalary * 5 / 100;
		return fixedSalary+benefits - pensionFounds - tax;
	}

	public void updateMonthQuota(float addQuota) {
		monthQuota = monthQuota + addQuota;
	}
}
