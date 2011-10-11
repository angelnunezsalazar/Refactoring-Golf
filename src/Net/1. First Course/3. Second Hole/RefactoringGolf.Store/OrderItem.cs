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
            decimal discount = 0;
            if (Product.Category == ProductCategory.Accessories)
            {
                discount = this.CalculateAccessoriesDiscount();
            }
            if (Product.Category == ProductCategory.Bikes)
            {
                discount = this.CalculateBikesDiscount();
            }
            if (Product.Category == ProductCategory.Cloathing)
            {
                discount = this.CalculateCloathingDiscount();
            }
            return this.UnitPricePerQuantity() - discount;
        }

        private decimal CalculateAccessoriesDiscount()
        {
            decimal discount = 0;
            if (this.UnitPricePerQuantity() >= 100)
            {
                discount = this.UnitPricePerQuantity() * 10 / 100;
            }
            return discount;
        }

        private decimal CalculateBikesDiscount()
        {
            return this.UnitPricePerQuantity() * 20 / 100;
        }

        private decimal CalculateCloathingDiscount()
        {
            decimal discount = 0;
            if (this.Quantity > 2)
            {
                discount = this.Product.UnitPrice;
            }
            return discount;
        }

        private decimal UnitPricePerQuantity()
        {
            return this.Product.UnitPrice * this.Quantity;
        }
    }
}