package refactoringgolf.store;

public class AccessoriesDiscount implements CategoryDiscount {

	public float calculateDiscount(OrderItem orderItem) {
		float discount = 0;
		float unitPricePerQuantity = orderItem.unitPricePerQuantity();
		if (unitPricePerQuantity >= 100) {
			discount = unitPricePerQuantity * 10 / 100;
		}
		return discount;
	}

}
