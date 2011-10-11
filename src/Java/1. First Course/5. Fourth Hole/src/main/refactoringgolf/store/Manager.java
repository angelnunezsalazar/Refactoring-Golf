package refactoringgolf.store;

import java.util.Collections;
import java.util.HashSet;
import java.util.Set;

public class Manager extends Employee {

	protected Set<Employee> subordinates = new HashSet<Employee>();

	public Manager(String firstName, String lastName, float fixedSalary) {
		super(firstName, lastName, fixedSalary);
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
	
	@Override
	protected float salaryBenefits() {
		return this.subordinates.size() * 20;
	}
}
