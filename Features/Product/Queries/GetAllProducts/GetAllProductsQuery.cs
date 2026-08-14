using CQRS_Project.Models;
using CQRS_Project.Result;
using MediatR;

namespace CQRS_Project.Features.Product.Queries.GetAllProducts
{
    public record GetAllProductsQuery() : IRequest<Result<List<product>>>;
}
