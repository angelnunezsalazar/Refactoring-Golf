package refactoringgolf.store;

import java.util.Date;
import java.util.HashSet;
import java.util.Set;

public class Order {

	private Customer customer;
	private Salesman salesman;
	private Date orderedOn;
	private String deliveryStreet;
	private String deliveryCity;
	private String deliveryCountry;
	private Set<OrderItem> items;

	public Order(Customer customer, Salesman salesman, String deliveryStreet, String deliveryCity, String deliveryCountry, Date orderedOn) {
		this.customer = customer;
		this.salesman = salesman;
		this.deliveryStreet = deliveryStreet;
		this.deliveryCity = deliveryCity;
		this.deliveryCountry = deliveryCountry;
		this.orderedOn = orderedOn;
		this.items = new HashSet<OrderItem>();
	}

	public Customer getCustomer() {
		return customer;
	}

	public Salesman getSalesman() {
		return salesman;
	}

	public Date getOrderedOn() {
		return orderedOn;
	}

	public String getDeliveryStreet() {
		return deliveryStreet;
	}

	public String getDeliveryCity() {
		return deliveryCity;
	}

	public String getDeliveryCountry() {
		return deliveryCountry;
	}

	public Set<OrderItem> getItems() {
		return items;
	}

	/*
	 * Return the total of the order
	 */
	public float total() {
		float totalAmount = 0;
		for (OrderItem item : items) {

			// Calculate the Item Total
			float discount = 0;
			float itemAmount = this.calculateItemAmount(item);
			
			if (item.getProduct().getCategory() == ProductCategory.Accessories) {
				discount = 0;
				if (itemAmount >= 100) {
					discount = itemAmount * 10 / 100;
				}
			}

			if (item.getProduct().getCategory() == ProductCategory.Components) {
				discount = itemAmount * 5 / 100;
			}

			if (item.getProduct().getCategory() == ProductCategory.Bikes) {
				discount = itemAmount * 15 / 100;
			}

			if (item.getProduct().getCategory() == ProductCategory.Cloathing) {
				discount = 0;
				if (item.getQuantity() > 2) {
					discount = item.getProduct().getUnitPrice();
				}
			}
			itemAmount = itemAmount - discount;

			totalAmount += itemAmount;
		}

		// Calculate the shipping cost and tax rate
		if (this.deliveryCountry == "USA")
			// totalAmount=totalItemAmount + tax + 0 de shipping
			return totalAmount + totalAmount * 5 / 100;

		// totalAmount=totalItemAmount + tax + 15 de shipping
		return totalAmount + totalAmount * 5 / 100 + 15;
	}

	private float calculateItemAmount(OrderItem item) {
		return item.getProduct().getUnitPrice() * item.getQuantity();
	}
}
