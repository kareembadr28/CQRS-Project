using CQRS_Project.Models;
using MediatR;

namespace CQRS_Project.Features.Product.Commands.CreateProduct
{
    public record CreateProductCommand(string Name) : IRequest<product>;
    
    }
