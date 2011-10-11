package refactoringgolf.store;


public abstract class Employee {

	protected String firstName;
	protected String lastName;
	protected float fixedSalary;
	protected Employee manager;
	protected String street;
	protected String city;
	protected String country;
	protected Employee(String firstName, String lastName, float fixedSalary) {
		this.firstName = firstName;
		this.lastName = lastName;
		this.fixedSalary = fixedSalary;
	}

	public String getFirstName() {
		return firstName;
	}

	public String getLastName() {
		return lastName;
	}

	public float getFixedSalary() {
		return fixedSalary;
	}

	public Employee getManager() {
		return manager;
	}

	public String getStreet() {
		return street;
	}

	public void setStreet(String street) {
		this.street = street;
	}

	public String getCity() {
		return city;
	}

	public void setCity(String city) {
		this.city = city;
	}

	public String getCountry() {
		return country;
	}

	public void setCountry(String country) {
		this.country = country;
	}

	public float netSalary() {
		float benefits = salaryBenefits();
		float pensionFounds = this.fixedSalary * 10 / 100;
		float tax = 0;
		if (fixedSalary > 3500)
			tax = fixedSalary * 5 / 100;
		return fixedSalary + benefits - pensionFounds - tax;
	}
	
	protected abstract float salaryBenefits();
}
