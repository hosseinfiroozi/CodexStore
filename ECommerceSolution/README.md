# ECommerceSolution

This sample solution demonstrates a Clean Architecture Web API built with .NET 8.

## Projects
- **ECommerce.Domain** – domain entities and repository interfaces.
- **ECommerce.Application** – application layer with CQRS handlers and DTOs.
- **ECommerce.Infrastructure** – EF Core data access and service implementations.
- **ECommerce.WebApi** – ASP.NET Core Web API exposing endpoints.
- **ECommerce.Tests** – unit tests.

## Getting Started
1. Ensure [.NET 8 SDK](https://dotnet.microsoft.com/download) and SQL Server are installed.
2. Update `ECommerce.WebApi/appsettings.json` connection string and JWT key as needed.
3. From the solution root run:
   ```bash
   dotnet restore
   dotnet build
   dotnet ef database update --project ECommerce.Infrastructure
   dotnet run --project ECommerce.WebApi
   ```
4. API documentation is available at `/swagger` when running.

This solution uses MediatR for CQRS, AutoMapper for mapping, Serilog for logging, and JWT authentication.
