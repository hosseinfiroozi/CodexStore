using AutoMapper;
using ECommerce.Application.Features.Products.Handlers;
using ECommerce.Application.Features.Products.Queries;
using ECommerce.Application.Mappings;
using ECommerce.Domain.Entities;
using ECommerce.Domain.Interfaces;
using Moq;
using Xunit;

namespace ECommerce.Tests.UnitTests
{
    public class ProductTests
    {
        [Fact]
        public async Task GetAllProducts_ReturnsProducts()
        {
            var products = new List<Product> { new Product { Id = 1, Name = "Test", Price = 9.99m } };
            var repoMock = new Mock<IProductRepository>();
            repoMock.Setup(r => r.GetAllAsync()).ReturnsAsync(products);
            var uowMock = new Mock<IUnitOfWork>();
            uowMock.Setup(u => u.Products).Returns(repoMock.Object);
            var mapper = new MapperConfiguration(cfg => cfg.AddProfile<MappingProfile>()).CreateMapper();
            var handler = new GetAllProductsHandler(uowMock.Object, mapper);

            var result = await handler.Handle(new GetAllProductsQuery(), CancellationToken.None);

            Assert.Single(result);
        }
    }
}
