using ECommerce.Application.DTOs;
using MediatR;

namespace ECommerce.Application.Features.Products.Commands
{
    public record CreateProductCommand(ProductDto Product) : IRequest<int>;
}
