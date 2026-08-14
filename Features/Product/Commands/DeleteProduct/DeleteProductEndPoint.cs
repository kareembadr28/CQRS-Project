using CQRS_Project.Result;
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
                return result.ToHttpResult();
            });
        }
    }
}
