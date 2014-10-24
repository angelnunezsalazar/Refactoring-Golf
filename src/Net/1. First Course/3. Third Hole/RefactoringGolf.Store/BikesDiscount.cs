namespace RefactoringGolf.Stack
{
    public class BikesDiscount : ICategoryDiscount
    {
        public decimal CalculateDiscount(OrderItem orderItem)
        {
            return orderItem.ItemAmount() * 20 / 100;
        }
    }
}