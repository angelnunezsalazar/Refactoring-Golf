package refactoringgolf.store;

public class AccessoriesDiscount implements CategoryDiscount{

	public float calculateDiscount(OrderItem orderItem) {
		float discount = 0;
		if (orderItem.getUnitPricePerQuantity() >= 100) {
			discount = orderItem.getUnitPricePerQuantity() * 10 / 100;
		}
		return discount;
	}

}
