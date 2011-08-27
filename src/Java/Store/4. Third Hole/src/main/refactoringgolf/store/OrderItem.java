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
		float itemAmount = getUnitPricePerQuantity();
		
		if (getProduct().getCategory() == ProductCategory.Accessories) {
			discount = new AccessoriesDiscount().calculateDiscount(this);
		}
	
		if (getProduct().getCategory() == ProductCategory.Components) {
			discount = new ComponentsDiscount().calculateDiscount(this);
		}
	
		if (getProduct().getCategory() == ProductCategory.Bikes) {
			discount = new BikesDiscount().calculateDiscount(this);
		}
	
		if (getProduct().getCategory() == ProductCategory.Cloathing) {
			discount = new CloathingDiscount().calculateDiscount(this);
		}
		itemAmount = itemAmount - discount;
		return itemAmount;
	}

	public float getUnitPricePerQuantity() {
		return getProduct().getUnitPrice() * getQuantity();
	}
}
