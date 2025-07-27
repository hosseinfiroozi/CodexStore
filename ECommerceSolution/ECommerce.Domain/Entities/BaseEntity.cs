namespace ECommerce.Domain.Entities
{
    /// <summary>
    /// Base entity with auditing fields.
    /// </summary>
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
