using CQRS_Project.Repositories.Interface;
using CQRS_Project.Result;
using MediatR;

namespace CQRS_Project.Features.Product.Commands.DeleteProduct
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, Result<bool>>
    {
        private readonly IProductRepository _productRepository;
        public DeleteProductCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public Task<Result<bool>> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
          var result= _productRepository.DeleteProduct(request.Id);
            return Task.FromResult(Result<bool>.Success(result));

        }
    }
}
