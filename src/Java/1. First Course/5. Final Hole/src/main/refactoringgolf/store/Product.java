package refactoringgolf.store;

public class Product {

	/* The Name */
	public String name;

	/* The UnitPrice */
	public float unitPrice;

	/* The Category */
	public ProductCategory category;

	/* The Image */
	public ImageInfo image;

	/* The Category */
	public int unitsInStock;

	public Product(String name, float unitPrice, ProductCategory category, ImageInfo image) {
		this.name = name;
		this.unitPrice = unitPrice;
		this.category = category;
		this.image = image;
	}

	public String getName() {
		return name;
	}

	public float getUnitPrice() {
		return unitPrice;
	}

	public ProductCategory getCategory() {
		return category;
	}

	public ImageInfo getImage() {
		return image;
	}

	public int getUnitsInStock() {
		return unitsInStock;
	}

	public void setUnitsInStock(int unitsInStock) {
		this.unitsInStock = unitsInStock;
	}

	public String toXml() {
		return "<product>" + "<name>" + name + "</name>" + "<category>"
				+ category + "</category>" + "</product>";
	}
}
