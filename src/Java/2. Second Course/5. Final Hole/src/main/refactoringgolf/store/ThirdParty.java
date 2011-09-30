package refactoringgolf.store;

public class ThirdParty {

	private String phoneNumber;
	private String contactName;

	public ThirdParty(String phoneNumber) {
		this.phoneNumber = phoneNumber;
	}

	public String getPhoneNumber() {
		return phoneNumber;
	}

	public String getContactName() {
		return contactName;
	}

	public String formatPhone() {
		return String.format("CountryCode:%s - Citycode:%s - LocalNumber:%s", phoneNumber.substring(0, 2), phoneNumber.substring(2, 4), phoneNumber.substring(4));
	}
}
