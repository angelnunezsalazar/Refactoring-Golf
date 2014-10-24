package refactoringgolf.store;

public class BikesDiscount implements CategoryDiscount{

	public float calculateDiscount(OrderItem orderItem) {
		return orderItem.itemAmount() * 20 / 100;
	}

}
