using CQRS_Project.Result;
using MediatR;

namespace CQRS_Project.Features.Product.Commands.UpdateProduct
{
    public static class UpdateProductCommandEndpoint
    {
        public static void MapUpdateProductCommandEndpoint(this IEndpointRouteBuilder app)
        {
            app.MapPut("/api/products", async ( UpdateProductCommand command, IMediator mediator) =>
            {
                
                var result = await mediator.Send(command);
                return result.ToHttpResult();
            });
        }
    }
}
