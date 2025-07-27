using ECommerce.Application.DTOs;
using MediatR;

namespace ECommerce.Application.Features.Orders.Commands
{
    public record PlaceOrderCommand(OrderDto Order) : IRequest<int>;
}
