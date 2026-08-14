using CQRS_Project.Models;
using CQRS_Project.Result;
using MediatR;

namespace CQRS_Project.Features.Product.Commands.CreateProduct
{
    public record CreateProductCommand(string Name) : IRequest<Result<product>>;
    
    }
