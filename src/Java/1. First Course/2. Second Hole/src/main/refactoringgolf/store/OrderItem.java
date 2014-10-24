package refactoringgolf.store;

public class OrderItem {

	private Product product;
	private int quantity;

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
		return itemAmount() - discount;
	}

	private float calculateAccessoriesDiscount() {
		float discount = 0;
		float unitPricePerQuantity = itemAmount();
		if (unitPricePerQuantity >= 100) {
			discount = unitPricePerQuantity * 10 / 100;
		}
		return discount;
	}

	private float calculateBikesDiscount() {
		return itemAmount() * 20 / 100;
	}

	private float calculateCloathingDiscount() {
		float discount = 0;
		if (getQuantity() > 2) {
			discount = getProduct().getUnitPrice();
		}
		return discount;
	}

	private float itemAmount() {
		return getProduct().getUnitPrice() * getQuantity();
	}
}
