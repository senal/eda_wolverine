namespace Order.Create
{
    public record CreateOrder ( Guid Id, Guid CustomerId, List<Item> Items);
    public record Item (Guid Id, Guid ProductId, int Quantity);
}
