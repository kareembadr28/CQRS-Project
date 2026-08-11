using MediatR;

namespace CQRS_Project.Features.Product.Commands.DeleteProduct
{
   public record DeleteProductCommand(int Id) : IRequest<bool>;
}
