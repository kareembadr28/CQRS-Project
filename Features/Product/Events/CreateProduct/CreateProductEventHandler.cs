using MediatR;

namespace CQRS_Project.Features.Product.Events.CreateProduct
{
    public class CreateProductEventHandler : INotificationHandler<CreateProductEvent>
    {
        private readonly ILogger<CreateProductEventHandler> _logger;
        public CreateProductEventHandler(ILogger<CreateProductEventHandler> logger)
        {
            _logger = logger;
        }
        public Task Handle(CreateProductEvent notification, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling CreateProductEvent_____________________________");
            _logger.LogInformation($"Product Created: Id={notification.Id}, Name={notification.Name}");
            return Task.CompletedTask;
        }
    }
}
