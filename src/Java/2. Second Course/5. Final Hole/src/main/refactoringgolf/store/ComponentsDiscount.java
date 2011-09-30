package refactoringgolf.store;

public class ComponentsDiscount implements CategoryDiscount{

	public float calculateDiscount(OrderItem orderItem) {
		return orderItem.getUnitPricePerQuantity() * 5 / 100;
	}

}
