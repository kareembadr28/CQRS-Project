using MediatR;

namespace CQRS_Project.Features.Product.Events.CreateProduct
{
  public record CreateProductEvent(int Id, string Name) : INotification;
}
