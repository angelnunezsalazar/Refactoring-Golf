package refactoringgolf.store;

import static org.junit.Assert.assertEquals;

import org.junit.Test;

import refactoringgolf.store.ImageInfo;
import refactoringgolf.store.Product;
import refactoringgolf.store.ProductCategory;

public class ProductTest {

	@Test
	public void productImageReturnTheType() {
		ImageInfo imageInfo = new ImageInfo("Bike01.jpg");

		String type = imageInfo.getImageType();

		assertEquals("jpg", type);
	}

	@Test
	public void serializeToXml() {
		Product product = createProduct();

		String xml = product.toXml();

		assertEquals("<product><name>Black Bike</name><category>Bikes</category></product>", xml);
	}

	private Product createProduct() {
		return new Product("Black Bike", 250, ProductCategory.Bikes, new ImageInfo("Bike01.jpg"));
	}
}
