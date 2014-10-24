package refactoringgolf.store;

import java.util.Collections;
import java.util.HashSet;
import java.util.Set;

public abstract class Employee {

	protected String firstName;
	protected String lastName;
	protected float fixedSalary;
	protected Employee manager;
	protected String street;
	protected String city;
	protected String country;
	protected Set<Employee> subordinates = new HashSet<Employee>();

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

	public Set<Employee> getSubordinates() {
		return Collections.unmodifiableSet(subordinates);
	}

	public void addSubordinate(Employee subordinate) {
		subordinates.add(subordinate);
		subordinate.manager = this;
	}

	public void removeSubordinate(Employee subordinate) {
		subordinates.remove(subordinate);
		subordinate.manager = null;
	}
}
