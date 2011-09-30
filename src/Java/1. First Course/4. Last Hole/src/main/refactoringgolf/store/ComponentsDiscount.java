package refactoringgolf.store;

public class ComponentsDiscount implements CategoryDiscount {

	public float calculateDiscount(OrderItem orderItem) {
		return orderItem.unitPricePerQuantity() * 5 / 100;
	}

}
