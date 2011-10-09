package refactoringgolf.store;

public class OrderItem {

	public Product product;
	public int quantity;

	/*
	 * Order Item Constructor
	 */
	public OrderItem(Product product, int quantity) {
		this.product = product;
		this.quantity = quantity;
	}

	public Product getProduct() {
		return product;
	}

	public int getQuantity() {
		return quantity;
	}

	public float total() {
		float discount = 0;
		if (getProduct().getCategory() == ProductCategory.Accessories) {
			discount = calculateAccessoriesDiscount();
		}
		if (getProduct().getCategory() == ProductCategory.Bikes) {
			discount = calculateBikesDiscount();
		}
		if (getProduct().getCategory() == ProductCategory.Cloathing) {
			discount = calculateCloathingDiscount();
		}
		return unitPricePerQuantity() - discount;
	}

	private float calculateAccessoriesDiscount() {
		float discount = 0;
		float unitPricePerQuantity = unitPricePerQuantity();
		if (unitPricePerQuantity >= 100) {
			discount = unitPricePerQuantity * 10 / 100;
		}
		return discount;
	}

	private float calculateBikesDiscount() {
		return unitPricePerQuantity() * 20 / 100;
	}

	private float calculateCloathingDiscount() {
		float discount = 0;
		if (getQuantity() > 2) {
			discount = getProduct().getUnitPrice();
		}
		return discount;
	}

	private float unitPricePerQuantity() {
		return getProduct().getUnitPrice() * getQuantity();
	}
}
