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
            decimal totalAmount = 0;
            foreach (var item in this.Items)
            {
                decimal totalItems = item.Product.UnitPrice * item.Quantity;
                if (item.Product.Category == ProductCategory.Accessories)
                {
                    decimal booksDiscount = 0;
                    if (totalItems >= 100)
                    {
                        booksDiscount = totalItems * 10 / 100;
                    }
                    totalItems = totalItems - booksDiscount;
                }
                if (item.Product.Category == ProductCategory.Bikes)
                {
                    totalItems = totalItems - totalItems * 20 / 100;
                }
                if (item.Product.Category == ProductCategory.Cloathing)
                {
                    decimal cloathingDiscount = 0;
                    if (item.Quantity > 2)
                    {
                        cloathingDiscount = item.Product.UnitPrice;
                    }
                    totalItems = totalItems - cloathingDiscount;
                }
                totalAmount += totalItems;
            }

            if (this.DeliveryCountry == "USA")
            {
                //totalAmount=totalItemAmount + tax + 0 shipping
                return totalAmount + totalAmount * 5 / 100;
            }

            //totalAmount=totalItemAmount + tax + 15 shipping
            return totalAmount + totalAmount * 5 / 100 + 15;
        }
    }
}