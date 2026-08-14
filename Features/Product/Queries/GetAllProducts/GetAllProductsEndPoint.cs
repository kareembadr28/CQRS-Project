using CQRS_Project.Result;
using MediatR;

namespace CQRS_Project.Features.Product.Queries.GetAllProducts
{
    public static class GetAllProductsEndPoint
    {
        public static void MapGetAllProductsEndPoint(this IEndpointRouteBuilder app)
        {
            app.MapGet("/api/products", async (IMediator mediator) =>
            {
                var query = new GetAllProductsQuery();
                var result = await mediator.Send(query);
                return result.ToHttpResult();

            });
         
        }
    }
}
