package refactoringgolf.store;

public class BikesDiscount implements CategoryDiscount{

	public float calculateDiscount(OrderItem orderItem) {
		return orderItem.unitPricePerQuantity() * 20 / 100;
	}

}
