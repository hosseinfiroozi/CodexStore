using ECommerce.Domain.Interfaces;
using ECommerce.Infrastructure.Persistence;

namespace ECommerce.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ECommerceDbContext _context;
        public IProductRepository Products { get; }
        public IOrderRepository Orders { get; }

        public UnitOfWork(ECommerceDbContext context, IProductRepository products, IOrderRepository orders)
        {
            _context = context;
            Products = products;
            Orders = orders;
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await _context.SaveChangesAsync(cancellationToken);
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
