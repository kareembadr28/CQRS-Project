using MediatR;

namespace CQRS_Project.Features.Product.Commands.CreateProduct
{
    public static class CreateProductEndPoint
    {
        public static void MapCreateProductEndPoint(this IEndpointRouteBuilder app)
        {
            app.MapPost("/api/products", async (CreateProductCommand command, IMediator mediator) =>
            {
                var result = await mediator.Send(command);
                if (result == null)
                {
                    return Results.BadRequest();
                }
                return Results.Created($"/api/products/{result.Id}", result);
            });
        }
    }
}
