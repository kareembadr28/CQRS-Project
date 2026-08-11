using MediatR;

namespace CQRS_Project.Features.Product.Commands.DeleteProduct
{
    public static class DeleteProductEndPoint
    {
        public static void MapDeleteProductEndPoint(this IEndpointRouteBuilder app)
        {
            app.MapDelete("/api/products/{id}", async (int id, IMediator mediator) =>
            {
                var command = new DeleteProductCommand(id);
                var result = await mediator.Send(command);
                if (result)
                {
                    return Results.Ok($"Product with Id {id} deleted successfully.");
                }
                else
                {
                    return Results.NotFound($"Product with Id {id} not found.");
                }
            });
        }
    }
}
