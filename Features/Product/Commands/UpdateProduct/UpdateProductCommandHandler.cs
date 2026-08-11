using CQRS_Project.Models;
using CQRS_Project.Repositories.Interface;
using MediatR;

namespace CQRS_Project.Features.Product.Commands.UpdateProduct
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, product>
    {
        private readonly IProductRepository _productRepository;
        public UpdateProductCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public Task<product> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new product
            {
                Id = request.Id,
                Name = request.Name
            };
            var result = _productRepository.UpdateProduct(product);
            return Task.FromResult(result);
        }
    }
}
