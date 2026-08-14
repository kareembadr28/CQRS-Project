using CQRS_Project.Models;
using CQRS_Project.Result;
using MediatR;

namespace CQRS_Project.Features.Product.Commands.UpdateProduct
{
  public record UpdateProductCommand(int Id, string Name) : IRequest<Result<product>>;
}
