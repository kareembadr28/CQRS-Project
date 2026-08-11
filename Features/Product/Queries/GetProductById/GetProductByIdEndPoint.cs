using MediatR;

namespace CQRS_Project.Features.Product.Queries.GetProductById
{
    public static class GetProductByIdEndPoint
    {
        public static void MapGetProductByIdEndPoint(this IEndpointRouteBuilder app)
        {
            app.MapGet("/api/products/{id}", async (int id, IMediator mediator) =>
            {
                var query = new GetProductById(id);
                var result = await mediator.Send(query);
                if (result == null)
                {
                    return Results.NotFound();
                }
                return Results.Ok(result);
            });

        }
    }
}
