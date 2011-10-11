namespace RefactoringGolf.Store
{
    public interface ICategoryDiscount
    {
        decimal CalculateDiscount(OrderItem orderItem);
    }
}