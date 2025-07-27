using ECommerce.Domain.Entities;

namespace ECommerce.Domain.Interfaces
{
    public interface IOrderRepository
    {
        Task<Order?> GetByIdAsync(int id);
        Task AddAsync(Order order);
        Task<IEnumerable<Order>> GetOrdersByCustomer(int customerId);
    }
}
