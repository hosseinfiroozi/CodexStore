namespace ECommerce.Infrastructure.Services
{
    public interface IPaymentService
    {
        Task<bool> ProcessPayment(int orderId, decimal amount);
    }

    public class PaymentService : IPaymentService
    {
        public Task<bool> ProcessPayment(int orderId, decimal amount)
        {
            // Mock payment processing
            return Task.FromResult(true);
        }
    }
}
