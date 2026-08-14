using CQRS_Project.Models;
using CQRS_Project.Result;
using MediatR;

namespace CQRS_Project.Features.Product.Queries.GetProductById
{
 public record GetProductById(int Id) : IRequest<Result<product>>;
}
