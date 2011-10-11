namespace RefactoringGolf.Store
{
    using System;
    using System.Collections.Generic;

    public class Order
    {
        public Customer Customer { get; private set; }

        public Salesman Salesman { get; private set; }

        public DateTime OrderedOn { get; private set; }

        public string DeliveryStreet { get; private set; }

        public string DeliveryCity { get; private set; }

        public string DeliveryCountry { get; private set; }

        public IList<OrderItem> Items { get; private set; }

        public Order(Customer customer, Salesman salesman, string deliveryStreet, string deliveryCity, string deliveryCountry, DateTime orderedOn)
        {
            Customer = customer;
            Salesman = salesman;
            DeliveryStreet = deliveryStreet;
            DeliveryCity = deliveryCity;
            DeliveryCountry = deliveryCountry;
            OrderedOn = orderedOn;
            Items = new List<OrderItem>();
        }

        public decimal Total()
        {
            var totalItems = this.TotalItems();
            var tax = this.Tax(totalItems);
            var shipping = this.Shipping();

            return totalItems + tax + shipping;
        }

        private int Shipping()
        {
            int shipping = 15;
            if (this.DeliveryCountry == "USA")
            {
                shipping = 0;
            }
            return shipping;
        }

        private decimal Tax(decimal totalItems)
        {
            var tax = totalItems * 5 / 100;
            return tax;
        }

        private decimal TotalItems()
        {
            decimal totalItems = 0;
            foreach (var item in this.Items)
            {
                totalItems += item.Total();
            }
            return totalItems;
        }
    }
}