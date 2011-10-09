namespace RefactoringGolf.Stack.Tests
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class OrderTests
    {
        [TestMethod]
        public void HoldManyOrderItems()
        {
            Order order = CreateOrder(null);
            OrderItem orderItem = CreateOrderItem(10, ProductCategory.Accessories, 1);

            AddItemToOrder(order, orderItem);

            Assert.AreEqual(1, order.Items.Count);
        }

        [TestMethod]
        public void ReturnTheTotalWithAccessoriesDiscount()
        {
            Order order = CreateOrder("USA");
            OrderItem orderItem = CreateOrderItem(50, ProductCategory.Accessories, 2);
            AddItemToOrder(order, orderItem);

            decimal total = order.Total();

            Assert.AreEqual(94.5m, total);
        }

        [TestMethod]
        public void ReturnTheTotalWithBikesDiscount()
        {
            Order order = CreateOrder("USA");
            OrderItem orderItem = CreateOrderItem(200, ProductCategory.Bikes, 2);
            AddItemToOrder(order, orderItem);

            decimal total = order.Total();

            Assert.AreEqual(336m, total);
        }

        [TestMethod]
        public void ReturnTheTotalWithCloathingDiscount()
        {
            Order order = CreateOrder("USA");
            OrderItem orderItem = CreateOrderItem(100, ProductCategory.Cloathing, 3);
            AddItemToOrder(order, orderItem);

            decimal total = order.Total();

            Assert.AreEqual(210m, total);
        }

        [TestMethod]
        public void ReturnTheTotalWithShippingCostWhenDeliveryCountryIsOutsideUSA()
        {
            Order order = CreateOrder("Peru");

            decimal total = order.Total();

            Assert.AreEqual(15m, total);
        }

        private Order CreateOrder(string deliveryCountry)
        {
            var customer = new Customer("Luis", "Palacios", "54115678654");
            var salesman = new Salesman("Alberto", "Martinez", 4000, 4);
            return new Order(customer, salesman, "Los claveles 452", "New York", deliveryCountry, DateTime.Now);
        }

        private OrderItem CreateOrderItem(int unitPrice, ProductCategory productCategory, int quantity)
        {
            Product product = new Product("Nombre", unitPrice, productCategory, null);
            return new OrderItem(product, quantity);
        }

        private void AddItemToOrder(Order order, OrderItem orderItem)
        {
            order.Items.Add(orderItem);
        }
    }
}