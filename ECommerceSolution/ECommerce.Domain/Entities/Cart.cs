namespace ECommerce.Domain.Entities
{
    public class Cart : BaseEntity
    {
        public int CustomerId { get; set; }
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
