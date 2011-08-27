namespace Before
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

        /*
         * Return the total of the order
         */
        public decimal Total
        {
            get
            {
                decimal totalAmount = 0;
                foreach (var item in this.Items)
                {
                    //Calculate the Item Total
                    decimal itemAmount = this.CalculateItemAmount(item);
                    if (item.Product.Category == ProductCategory.Accessories)
                    {
                        decimal booksDiscount = 0;
                        if (itemAmount >= 100)
                        {
                            booksDiscount = itemAmount * 10 / 100;
                        }
                        itemAmount = itemAmount - booksDiscount;
                    }

                    if (item.Product.Category == ProductCategory.Components)
                    {
                        //itemAmount=itemAmount-discount
                        itemAmount = itemAmount - itemAmount * 5 / 100;
                    }

                    if (item.Product.Category == ProductCategory.Bikes)
                    {
                        itemAmount = itemAmount - itemAmount * 15 / 100;
                    }

                    if (item.Product.Category == ProductCategory.Cloathing)
                    {
                        decimal discount = 0;
                        if (item.Quantity > 2)
                        {
                            discount = item.Product.UnitPrice;
                        }
                        itemAmount = itemAmount - discount;
                    }

                    totalAmount += itemAmount;
                }


                //Calculate the shipping cost and tax rate
                if (this.DeliveryCountry == "USA") 
                    //totalAmount=totalItemAmount + tax + 0 de shipping
                    return totalAmount + totalAmount * 5 / 100;

                //totalAmount=totalItemAmount + tax + 15 de shipping
                return totalAmount + totalAmount * 5 / 100 + 15;
            }
        }

        private decimal CalculateItemAmount(OrderItem item)
        {
            return item.Product.UnitPrice * item.Quantity;
        }
    }
}