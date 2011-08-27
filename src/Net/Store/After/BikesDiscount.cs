namespace After
{
    public class BikesDiscount:ICategoryDiscount
    {
        public decimal CalculateDiscount(OrderItem orderItem)
        {
            return orderItem.CalculatePartialTotal() * 15 / 100;
        }
    }
}