namespace After
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Order
    {
        public Customer Customer { get; private set; }

        public Salesman Salesman { get; private set; }

        public DateTime OrderedOn { get; private set; }

        public Address DeliveryAddress { get; private set; }

        private IList<OrderItem> items = new List<OrderItem>();

        public IEnumerable<OrderItem> Items
        {
            get
            {
                return items.ToArray();
            }
        }

        public Order(Customer customer, Salesman salesman, Address deliveryAddress, DateTime orderedOn)
        {
            Customer = customer;
            Salesman = salesman;
            DeliveryAddress = deliveryAddress;
            OrderedOn = orderedOn;
        }

        public void Add(OrderItem orderItem)
        {
            items.Add(orderItem);
        }

        public int CountItems
        {
            get
            {
                return items.Count;
            }
        }

        public decimal Total
        {
            get
            {
                return TotalItems() + Tax() + Shipping();
            }
        }

        private decimal TotalItems()
        {
            decimal totalItems = 0;
            foreach (var item in this.Items)
            {
                totalItems += item.CalculateTotal();
            }
            return totalItems;
        }

        private decimal Tax()
        {
            return TotalItems() * 5 / 100;
        }

        private decimal Shipping()
        {
            decimal shippingCost = 15;
            if (this.DeliveryAddress.Country == "USA")
                shippingCost = 0;
            return shippingCost;
        }
    }
}