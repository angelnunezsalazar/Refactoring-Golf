namespace RefactoringGolf.Stack
{
    public class AccessoriesDiscount : ICategoryDiscount
    {
        public decimal CalculateDiscount(OrderItem orderItem)
        {
            decimal discount = 0;
            if (orderItem.ItemAmount() >= 100)
            {
                discount = orderItem.ItemAmount() * 10 / 100;
            }
            return discount;
        }
    }
}