namespace Order.Domain
{
    public abstract class Entity
    {
        public Guid Id { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTimeOffset ModifiedAt { get; set; }
        public Guid ModifiedBy { get; set; }
    }
}
