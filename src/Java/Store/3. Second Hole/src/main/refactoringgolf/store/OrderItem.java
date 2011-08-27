package refactoringgolf.store;

public class OrderItem {
	
	public Product product;
	public int quantity;

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
		float itemAmount = unitPricePerQuantity();
		
		if (getProduct().getCategory() == ProductCategory.Accessories) {
			discount = calculateAccessoriesDiscount(itemAmount);
		}
	
		if (getProduct().getCategory() == ProductCategory.Components) {
			discount = calculateComponentsDiscount(itemAmount);
		}
	
		if (getProduct().getCategory() == ProductCategory.Bikes) {
			discount = calculateBikesDiscount(itemAmount);
		}
	
		if (getProduct().getCategory() == ProductCategory.Cloathing) {
			discount = calculateCloathingDiscount();
		}
		itemAmount = itemAmount - discount;
		return itemAmount;
	}

	private float calculateCloathingDiscount() {
		float discount;
		discount = 0;
		if (getQuantity() > 2) {
			discount = getProduct().getUnitPrice();
		}
		return discount;
	}

	private float calculateBikesDiscount(float itemAmount) {
		float discount;
		discount = itemAmount * 15 / 100;
		return discount;
	}

	private float calculateComponentsDiscount(float itemAmount) {
		float discount;
		discount = itemAmount * 5 / 100;
		return discount;
	}

	private float calculateAccessoriesDiscount(float itemAmount) {
		float discount;
		discount = 0;
		if (itemAmount >= 100) {
			discount = itemAmount * 10 / 100;
		}
		return discount;
	}
	
	private float unitPricePerQuantity() {
		return getProduct().getUnitPrice() * getQuantity();
	}
}
