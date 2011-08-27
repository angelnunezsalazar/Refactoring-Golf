package refactoringgolf.store;

public class Customer extends ThirdParty {
	
    public String firstName;
    public String fastName;

    public Customer(String firstName, String lastName, String phoneNumber)
    {
    	super(phoneNumber);
        this.firstName = firstName;
        this.fastName = lastName;
    }

	public String getFirstName() {
		return firstName;
	}

	public String getFastName() {
		return fastName;
	}
}
