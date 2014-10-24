package refactoringgolf.store;

import static org.junit.Assert.assertEquals;

import java.util.Date;

import org.junit.Test;

import refactoringgolf.store.Customer;
import refactoringgolf.store.Order;
import refactoringgolf.store.OrderItem;
import refactoringgolf.store.Product;
import refactoringgolf.store.ProductCategory;
import refactoringgolf.store.Salesman;

public class OrderTest {

	@Test
	public void holdManyOrderItems() {
		Order order = createOrder(null);
		OrderItem orderItem = createOrderItem(10, ProductCategory.Accessories, 1);

		addItemToOrder(order, orderItem);

		assertEquals(1, order.getItems().size(), 0);
	}

	@Test
	public void returnTheTotalWithAccessoriesDiscount() {
		Order order = createOrder("USA");
		OrderItem orderItem = createOrderItem(50, ProductCategory.Accessories, 2);
		addItemToOrder(order, orderItem);

		float total = order.total();

		assertEquals(94.5, total, 1);
	}

	@Test
	public void returnTheTotalWithBikesDiscount() {
		Order order = createOrder("USA");
		OrderItem orderItem = createOrderItem(200, ProductCategory.Bikes, 2);
		addItemToOrder(order, orderItem);

		float total = order.total();

		assertEquals(336, total, 0);
	}

	@Test
	public void returnTheTotalWithCloathingDiscount() {
		Order order = createOrder("USA");
		OrderItem orderItem = createOrderItem(100, ProductCategory.Cloathing, 3);
		addItemToOrder(order, orderItem);

		float total = order.total();

		assertEquals(210, total, 0);
	}

	@Test
	public void returnTheTotalWithShippingCostWhenDeliveryCountryIsOutsideUSA() {
		Order order = createOrder("Peru");

		float total = order.total();

		assertEquals(15, total, 0);
	}

	private Order createOrder(String deliveryCountry) {
		Customer customer = new Customer("Luis", "Palacios", "54115678654");
		Salesman salesman = new Salesman("Alberto", "Martinez", 4000, 4);
		return new Order(customer, salesman, "Los claveles 452", "New York", deliveryCountry, new Date());
	}

	private OrderItem createOrderItem(int unitPrice, ProductCategory productCategory, int quantity) {
		Product product = new Product("Nombre", unitPrice, productCategory, null);
		return new OrderItem(product, quantity);
	}

	private void addItemToOrder(Order order, OrderItem orderItem) {
		order.getItems().add(orderItem);
	}
}
