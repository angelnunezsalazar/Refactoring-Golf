namespace After
{
    public class AccessoriesDiscount : ICategoryDiscount
    {
        public decimal CalculateDiscount(OrderItem orderItem)
        {
            decimal discount = 0;
            if (orderItem.CalculatePartialTotal() >= 100)
            {
                discount = orderItem.CalculatePartialTotal() * 10 / 100;
            }
            return discount;
        }
    }
}