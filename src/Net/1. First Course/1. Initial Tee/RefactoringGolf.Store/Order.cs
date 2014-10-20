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
            decimal totalItems = 0;
            foreach (var item in this.Items)
            {
                decimal itemAmount = item.Product.UnitPrice * item.Quantity;
                if (item.Product.Category == ProductCategory.Accessories)
                {
                    decimal booksDiscount = 0;
                    if (itemAmount >= 100)
                    {
                        booksDiscount = itemAmount * 10 / 100;
                    }
                    itemAmount = itemAmount - booksDiscount;
                }
                if (item.Product.Category == ProductCategory.Bikes)
                {
                    // 20% discount for Bikes
                    itemAmount = itemAmount - itemAmount * 20 / 100;
                }
                if (item.Product.Category == ProductCategory.Cloathing)
                {
                    decimal cloathingDiscount = 0;
                    if (item.Quantity > 2)
                    {
                        cloathingDiscount = item.Product.UnitPrice;
                    }
                    itemAmount = itemAmount - cloathingDiscount;
                }
                totalItems += itemAmount;
            }

            if (this.DeliveryCountry == "USA")
            {
                //total=totalItems + tax + 0 shipping
                return totalItems + totalItems * 5 / 100;
            }

            //total=totalItems + tax + 15 shipping
            return totalItems + totalItems * 5 / 100 + 15;
        }
    }
}