using CQRS_Project.Models;
using MediatR;

namespace CQRS_Project.Features.Product.Queries.GetAllProducts
{
    public record GetAllProductsQuery() : IRequest<List<product>>;
}
