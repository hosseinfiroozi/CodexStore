namespace ECommerce.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository Products { get; }
        IOrderRepository Orders { get; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
