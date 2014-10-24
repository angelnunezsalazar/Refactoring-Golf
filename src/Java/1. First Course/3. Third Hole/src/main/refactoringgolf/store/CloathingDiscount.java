package refactoringgolf.store;

public class CloathingDiscount implements CategoryDiscount {

	public float calculateDiscount(OrderItem orderItem) {
		float discount = 0;
		if (orderItem.getQuantity() > 2) {
			discount = orderItem.getProduct().getUnitPrice();
		}
		return discount;
	}

}
