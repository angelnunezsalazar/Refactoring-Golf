namespace RefactoringGolf.Store
{
    public class BikesDiscount : ICategoryDiscount
    {
        public decimal CalculateDiscount(OrderItem orderItem)
        {
            return orderItem.UnitPricePerQuantity() * 20 / 100;
        }
    }
}