namespace RefactoringGolf.Stack
{
    public interface ICategoryDiscount
    {
        decimal CalculateDiscount(OrderItem orderItem);
    }
}