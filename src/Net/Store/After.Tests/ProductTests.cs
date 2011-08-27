namespace After.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using After;

    [TestClass]
    public class ProductTests
    {
        [TestMethod]
        public void ProductImageReturnTheType()
        {
            Product product = this.CreateProduct();

            string type = product.ImageType;

            Assert.AreEqual("jpg", type);
        }

        [TestMethod]
        public void SerializeToXml()
        {
            Product product = CreateProduct();

            string xml = product.ToXml();

            Assert.AreEqual("<product><name>Black Bike</name><category>Bikes</category></product>", xml);
        }

        private Product CreateProduct()
        {
            return new Product("Black Bike", 250, ProductCategory.Bikes, "Bike01.jpg");
        }
    }
}