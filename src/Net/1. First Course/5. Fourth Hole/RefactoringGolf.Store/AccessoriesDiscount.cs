namespace RefactoringGolf.Store
{
    public class AccessoriesDiscount : ICategoryDiscount
    {
        public decimal CalculateDiscount(OrderItem orderItem)
        {
            decimal discount = 0;
            if (orderItem.UnitPricePerQuantity() >= 100)
            {
                discount = orderItem.UnitPricePerQuantity() * 10 / 100;
            }
            return discount;
        }
    }
}