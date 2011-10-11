namespace RefactoringGolf.Stack
{
    public class OrderItem
    {
        public Product Product { get; private set; }

        public int Quantity { get; private set; }

        /*
         * Order Item Constructor
         */
        public OrderItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }

        public decimal Total()
        {
            return this.UnitPricePerQuantity() - this.CreateCategoryDiscount().CalculateDiscount(this);
        }

        private ICategoryDiscount CreateCategoryDiscount()
        {
            ICategoryDiscount categoryDiscount = null;
            if (this.Product.Category == ProductCategory.Accessories)
            {
                categoryDiscount = new AccessoriesDiscount();
            }
            if (this.Product.Category == ProductCategory.Bikes)
            {
                categoryDiscount = new BikesDiscount();
            }
            if (this.Product.Category == ProductCategory.Cloathing)
            {
                categoryDiscount = new CloathingDiscount();
            }
            return categoryDiscount;
        }

        public decimal UnitPricePerQuantity()
        {
            return this.Product.UnitPrice * this.Quantity;
        }
    }
}