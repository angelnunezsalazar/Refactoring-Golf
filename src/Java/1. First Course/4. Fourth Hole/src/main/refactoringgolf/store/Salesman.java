package refactoringgolf.store;

public class Salesman extends Employee {

	private int commissionPorcentage;
	private float monthQuota;

	public Salesman(String firstName, String lastName, float fixedSalary, int commissionPorcentage) {
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

	public void updateMonthQuota(float addQuota) {
		monthQuota = monthQuota + addQuota;
	}

	protected float salaryBenefits() {
		return monthQuota * commissionPorcentage / 100;
	}
}
