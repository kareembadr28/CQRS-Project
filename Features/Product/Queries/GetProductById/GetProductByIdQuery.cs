using CQRS_Project.Models;
using MediatR;

namespace CQRS_Project.Features.Product.Queries.GetProductById
{
 public record GetProductById(int Id) : IRequest<product>;
}
