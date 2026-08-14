using CQRS_Project.Models;
using CQRS_Project.Result;
using MediatR;

namespace CQRS_Project.Features.Product.Commands.DeleteProduct
{
   public record DeleteProductCommand(int Id) : IRequest<Result<bool>>;
}
