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

	public float total() {
		float totalItems = 0;
		for (OrderItem item : items) {
			float totalItem=0;
			float itemAmount = item.getProduct().getUnitPrice() * item.getQuantity();
			if (item.getProduct().getCategory() == ProductCategory.Accessories) {
				float booksDiscount = 0;
				if (itemAmount >= 100) {
					booksDiscount = itemAmount * 10 / 100;
				}
				totalItem = itemAmount - booksDiscount;
			}
			if (item.getProduct().getCategory() == ProductCategory.Bikes) {
				// 20% discount for Bikes
				totalItem = itemAmount - itemAmount * 20 / 100;
			}
			if (item.getProduct().getCategory() == ProductCategory.Cloathing) {
				float cloathingDiscount = 0;
				if (item.getQuantity() > 2) {
					cloathingDiscount = item.getProduct().getUnitPrice();
				}
				totalItem = itemAmount - cloathingDiscount;
			}
			totalItems += totalItem;
		}

		if (this.deliveryCountry == "USA"){
			// total=totalItems + tax + 0 shipping
			return totalItems + totalItems * 5 / 100;
		}

		// total=totalItemst + tax + 15 shipping
		return totalItems + totalItems * 5 / 100 + 15;
	}
}
