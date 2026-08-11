using CQRS_Project.Repositories.Interface;
using MediatR;

namespace CQRS_Project.Features.Product.Commands.DeleteProduct
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, bool>
    {
        private readonly IProductRepository _productRepository;
        public DeleteProductCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public Task<bool> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
          var result= _productRepository.DeleteProduct(request.Id);
            return Task.FromResult(result);

        }
    }
}
