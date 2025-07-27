namespace ECommerce.Application.DTOs
{
    public class OrderDto
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public List<ProductDto> Products { get; set; } = new();
        public decimal Total { get; set; }
    }
}
