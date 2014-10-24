namespace RefactoringGolf.Stack
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
            return totalItems * 5 / 100;
        }

        private decimal TotalItems()
        {
            decimal totalItems = 0;
            foreach (var item in this.Items)
            {
                var itemAmount = TotalItem(item);
                totalItems += itemAmount;
            }
            return totalItems;
        }

        private decimal TotalItem(OrderItem item)
        {
            decimal totalItem = 0;
            decimal itemAmount = item.Product.UnitPrice*item.Quantity;
            if (item.Product.Category == ProductCategory.Accessories)
            {
                decimal booksDiscount = 0;
                if (itemAmount >= 100)
                {
                    booksDiscount = itemAmount*10/100;
                }
                totalItem = itemAmount - booksDiscount;
            }
            if (item.Product.Category == ProductCategory.Bikes)
            {
                // 20% discount for Bikes
                totalItem = itemAmount - itemAmount * 20 / 100;
            }
            if (item.Product.Category == ProductCategory.Cloathing)
            {
                decimal cloathingDiscount = 0;
                if (item.Quantity > 2)
                {
                    cloathingDiscount = item.Product.UnitPrice;
                }
                totalItem = itemAmount - cloathingDiscount;
            }
            return totalItem;
        }
    }
}