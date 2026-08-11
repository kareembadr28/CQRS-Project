using CQRS_Project.Features.Product.Events.CreateProduct;
using CQRS_Project.Models;
using CQRS_Project.Repositories.Interface;
using MediatR;

namespace CQRS_Project.Features.Product.Commands.CreateProduct
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, product>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMediator _mediator;
        public CreateProductCommandHandler(IProductRepository productRepository, IMediator mediator)
        {
            _productRepository = productRepository;
            _mediator = mediator;
        }
        public Task<product> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product =new product
            {
                Id = new Random().Next(1, 10000),
                Name = request.Name
            };
          var result= _productRepository.CreateProduct(product);
            _mediator.Publish(new CreateProductEvent (result.Id,result.Name), cancellationToken);
            return Task.FromResult(result);

        }
    }
}
