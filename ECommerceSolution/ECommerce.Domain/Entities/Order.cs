namespace ECommerce.Domain.Entities
{
    public class Order : BaseEntity
    {
        public int CustomerId { get; set; }
        public ICollection<Product> Products { get; set; } = new List<Product>();
        public decimal Total => Products.Sum(p => p.Price);
    }
}
