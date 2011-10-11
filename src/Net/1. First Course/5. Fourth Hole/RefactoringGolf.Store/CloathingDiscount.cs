namespace RefactoringGolf.Stack
{
    public class CloathingDiscount : ICategoryDiscount
    {
        public decimal CalculateDiscount(OrderItem orderItem)
        {
            decimal discount = 0;
            if (orderItem.Quantity > 2)
            {
                discount = orderItem.Product.UnitPrice;
            }
            return discount;
        }
    }
}