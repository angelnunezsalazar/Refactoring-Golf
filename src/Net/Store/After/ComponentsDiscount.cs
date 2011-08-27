namespace After
{
    public class ComponentsDiscount:ICategoryDiscount
    {
        public decimal CalculateDiscount(OrderItem orderItem)
        {
            return orderItem.CalculatePartialTotal() * 5 / 100;
        }
    }
}