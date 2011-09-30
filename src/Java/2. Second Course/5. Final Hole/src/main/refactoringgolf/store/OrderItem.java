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
		float unitPricePerQuanity = getUnitPricePerQuantity();
		float discount = createCategoryDiscount().calculateDiscount(this);
		return unitPricePerQuanity - discount;
	}

	private CategoryDiscount createCategoryDiscount() {
		CategoryDiscount categoryDiscount=null;
		if (getProduct().getCategory() == ProductCategory.Accessories) {
			categoryDiscount = new AccessoriesDiscount();
		}
	
		if (getProduct().getCategory() == ProductCategory.Components) {
			categoryDiscount = new ComponentsDiscount();
		}
	
		if (getProduct().getCategory() == ProductCategory.Bikes) {
			categoryDiscount = new BikesDiscount();
		}
	
		if (getProduct().getCategory() == ProductCategory.Cloathing) {
			categoryDiscount = new CloathingDiscount();
		}
		return categoryDiscount;
	}

	public float getUnitPricePerQuantity() {
		return getProduct().getUnitPrice() * getQuantity();
	}
}
