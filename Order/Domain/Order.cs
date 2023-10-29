namespace Order.Domain
{
    public class Order : Entity
    {
        public Guid CustomerId { get; set; }
    }
}
